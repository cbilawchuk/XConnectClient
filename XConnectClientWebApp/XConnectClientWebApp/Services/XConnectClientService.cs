﻿using Sitecore.XConnect;
using Sitecore.XConnect.Client;
using Sitecore.XConnect.Client.WebApi;
using Sitecore.XConnect.Collection.Model;
using Sitecore.XConnect.Schema;
using Sitecore.Xdb.Common.Web;
using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Web;

namespace XConnectClientWebApp.Services
{
    /// <summary>
    ///     XConnectClientService - Use this class to connect to an XConnect instance and push contact/analytics info to.
    ///     
    ///     For more model information please visit:
    ///     Sitecore Collection Model Reference: https://doc.sitecore.net/developers/xp/xconnect/xconnect-model/core-collection-model/index.html
    ///     
    /// </summary>
    public class XConnectClientService
    {
        public void SetPageViewEvent(string Source)
        {
            HttpRequest request = HttpContext.Current.Request;

            // Get or Create a new contact
            var contact = this.GetOrSetContact(Source);

            // Add an Interaction
            var interaction = this.RegisterInteraction(contact);

            using (XConnectClient client = GetXConnectClient())
            {
                try
                {
                    //Add Device profile
                    interaction = AddDeviceProfile(client, contact, interaction);

                    // Add IpInfo Facet
                    client.SetFacet<IpInfo>(interaction, IpInfo.DefaultFacetKey, this.GetIpInfoFacet(request));

                    // Add WebVisit Facet
                    client.SetFacet<WebVisit>(interaction, WebVisit.DefaultFacetKey, this.GetWebVisitFacet(request));


                    // Add PageViewEvent
                    interaction.Events.Add(this.GetPageViewEvent(request));

                    // Apply facets and events, and submit
                    client.AddInteraction(interaction);
                    client.Submit();
                }
                catch (XdbExecutionException ex)
                {
                    //Failure: return null and log the errors.
                    Console.Write(ex.Message + ex.StackTrace);
                }
            }
        }

        public void SetPersonalInformationFacet(string Source, PersonalInformation facet)
        {
            HttpRequest request = HttpContext.Current.Request;

            // Get or Create a new contact
            var contact = this.GetOrSetContact(Source);

            // Add an Interaction
            var interaction = this.RegisterInteraction(contact);

            using (XConnectClient client = GetXConnectClient())
            {
                try
                {
                    //Add personal identification facet
                    client.SetFacet<PersonalInformation>(interaction, PersonalInformation.DefaultFacetKey, facet);
                    
                    // Apply facets and events, and submit
                    client.AddInteraction(interaction);
                    client.Submit();
                }
                catch (XdbExecutionException ex)
                {
                    //Failure: return null and log the errors.
                    Console.Write(ex.Message + ex.StackTrace);
                }
            }
        }


        private Interaction AddDeviceProfile(XConnectClient client, Contact contact, Interaction interaction)
        {
            DeviceProfile deviceProfile = new DeviceProfile(Guid.NewGuid());
            deviceProfile.LastKnownContact = contact;
            client.AddDeviceProfile(deviceProfile);
            interaction.DeviceProfile = deviceProfile;

            return interaction;
        }

        private  IpInfo GetIpInfoFacet(HttpRequest request)
        {
            //Add Ip info
            IpInfo ipInfo = new IpInfo(this.GetIP(request))
            {
                AreaCode = "",
                BusinessName = "",
                City = "",
                Country = ResolveCountry(request).ThreeLetterWindowsRegionName,
                Isp = "",
                Latitude = 0,
                Longitude = 0,
                LocationId = Guid.NewGuid(),
                MetroCode = "",
                PostalCode = "",
                Region = ResolveCountry(request).DisplayName,
                Url = request.Url.ToString(),
                Dns = request.Url.DnsSafeHost
            };
            return ipInfo;
        }

        private WebVisit GetWebVisitFacet(HttpRequest request)
        {
            //Add webVisit info
            WebVisit webVisit = new WebVisit()
            {
                Browser = GetBrowser(request),
                Language = GetUserLanguage(request),
                //OperatingSystem = "",
                Referrer = request.UrlReferrer.AbsoluteUri,
                IsSelfReferrer = IsSelfReferrer(request.UrlReferrer.AbsoluteUri),
                Screen = new ScreenData { ScreenWidth = request.Browser.ScreenPixelsWidth, ScreenHeight = request.Browser.ScreenPixelsHeight},
                SearchKeywords = "",
                SiteName = XConnectSettings.SiteSourceLabel
            };
            
            return webVisit;
        }

        private bool IsSelfReferrer(string referrer)
        {
            if(referrer.ToLower().Contains(XConnectSettings.AppDomain))
            {
                return true;
            }
            return false;
        }

        private string GetUserLanguage(HttpRequest request)
        {
            CultureInfo ci = this.ResolveCulture(request);
            return ci.TwoLetterISOLanguageName;
        }

        public CultureInfo ResolveCulture(HttpRequest request)
        {
            string[] languages = request.UserLanguages;
            if (languages == null || languages.Length == 0)
                return null;
            try
            {
                string language = languages[0].ToLowerInvariant().Trim();
                return CultureInfo.CreateSpecificCulture(language);
            }
            catch (ArgumentException)
            {
                return null;
            }
        }

        public RegionInfo ResolveCountry(HttpRequest request)
        {
            CultureInfo culture = this.ResolveCulture(request);
            if (culture != null)
                return new RegionInfo(culture.LCID);
            return null;
        }

        private PageViewEvent GetPageViewEvent(HttpRequest request)
        {
            PageViewEvent pageView = new PageViewEvent(DateTime.UtcNow, Guid.NewGuid(), 1, GetUserLanguage(request));
            pageView.Url = request.Url.ToString();

            return pageView;
        }

        //private Outcome GetOutcome()
        //{
        //    Outcome outcome = new Outcome(XConnectSettings.LoginGoalId, DateTime.UtcNow, "USD", 0);
        //    outcome.EngagementValue = 1;
        //    outcome.Text = "Logged on to ABC Application";

        //    return outcome;
        //}


        /// <summary>
        ///     Creates a new contact using the ContactSourceID and APPSourceID
        /// </summary>
        /// <param name="ContactSourceID">Unique ID for the contact.  </param>
        /// <returns></returns>
        private Contact CreateContact(string ContactSourceID)
        {           
            using (XConnectClient client = GetXConnectClient())
            {
                try
                {
                    var contactIdentifier = new[]
                    {
                        new ContactIdentifier(ContactSourceID, XConnectSettings.AppSourceID, ContactIdentifierType.Known)
                    };

                    Contact contact = new Contact(contactIdentifier);
                    client.AddContact(contact);
                    client.Submit();

                    return contact;
                }
                catch (XdbExecutionException ex)
                {
                    //Failure: return null and log the errors.
                    Console.Write(ex.Message + ex.StackTrace);
                    return null;
                }
            }
        }

        /// <summary>
        ///  Returns a Contact object, either finds an existing contact using the unique id or creates a new one.
        /// </summary>
        /// <param name="ContactSourceID">This is the unique id of the contact. (Eg: login ID, twtter handle, account ID, etc.)</param>
        /// <returns></returns>
        public Contact GetOrSetContact(string ContactSourceID)
        {
            using (XConnectClient client = GetXConnectClient())
            {
                try
                {
                    // For this app, using the ContactID try find an existing contact.
                    IdentifiedContactReference reference = new IdentifiedContactReference(ContactSourceID, XConnectSettings.AppSourceID);

                    Contact existingContact = client.Get<Contact>(
                        reference,
                        new ContactExpandOptions(
                            PersonalInformation.DefaultFacetKey,
                            Avatar.DefaultFacetKey,
                            ContactBehaviorProfile.DefaultFacetKey,
                            EmailAddressList.DefaultFacetKey
                            ));

                    if (existingContact == null)
                    {
                        //nope, no contact, then create a new one on the fly
                        return CreateContact(ContactSourceID);
                    }
                    else
                    {
                        //Return the contact to add interactions/events to
                        return existingContact;
                    }
                }
                catch (XdbExecutionException ex)
                {
                    //Failure: return null and log the errors.
                    Console.Write(ex.Message + ex.StackTrace);
                    return null;
                }
            }
        }        

        /// <summary>
        ///  This methods creates the secure connection between this app and XConnect. 
        ///  Note: Ensure that your web app has proper permission to access the LocalMachine cert store.
        /// </summary>
        /// <returns>XConnectClient client object.</returns>
        private XConnectClient GetXConnectClient()
        {
            try
            {


                XConnectClientConfiguration cfg;
                if (string.IsNullOrEmpty(XConnectSettings.XconnectThumbprint))
                {
                    cfg = new XConnectClientConfiguration(
                        new XdbRuntimeModel(CollectionModel.Model),
                        new Uri(XConnectSettings.XconnectUrl),
                        new Uri(XConnectSettings.XconnectUrl));
                }
                else
                {
                    CertificateWebRequestHandlerModifierOptions options =
                    CertificateWebRequestHandlerModifierOptions.Parse(string.Format("StoreName=My;StoreLocation=LocalMachine;FindType=FindByThumbprint;FindValue={0}", XConnectSettings.XconnectThumbprint));
                    var certificateModifier = new CertificateWebRequestHandlerModifier(options);

                    var collectionClient = new CollectionWebApiClient(new Uri(XConnectSettings.XconnectUrl + "/odata"), null, new[] { certificateModifier });
                    var searchClient = new SearchWebApiClient(new Uri(XConnectSettings.XconnectUrl + "/odata"), null, new[] { certificateModifier });
                    var configurationClient = new ConfigurationWebApiClient(new Uri(XConnectSettings.XconnectUrl + "/configuration"), null, new[] { certificateModifier });

                    cfg = new XConnectClientConfiguration(new XdbRuntimeModel(CollectionModel.Model), collectionClient, searchClient, configurationClient);
                }

                cfg.Initialize();

                var client = new XConnectClient(cfg);

                return client;
            }
            catch(XdbExecutionException ex)
            {
                Console.Write(ex.Message + ex.StackTrace);
                return null;
            }
        }

        private Interaction RegisterInteraction(Contact existingContact)
        {
            try
            {
                //Create the basic interaction and then add additional data as needed
                Interaction interaction = new Interaction(
                    existingContact, 
                    InteractionInitiator.Contact, 
                    channelId: XConnectSettings.OnlineChannelId, 
                    userAgent: XConnectSettings.SiteSourceLabel
                    );               

                return interaction;
            }
            catch (XdbExecutionException ex)
            {
                Console.Write(ex.Message + ex.StackTrace);
                return null;
            }
            
        }

        private String GetIP(HttpRequest request)
        {
            String ip = request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (string.IsNullOrEmpty(ip))
            {
                ip = request.ServerVariables["REMOTE_ADDR"];
            }

            return ip;
        }

        private BrowserData GetBrowser(HttpRequest request)
        {
            if (request != null)
            {
                BrowserData browser = new BrowserData
                {
                    BrowserMajorName = request.Browser.MajorVersion.ToString(),
                    BrowserMinorName = request.Browser.MinorVersionString,
                    BrowserVersion = request.Browser.Version
                };

                return browser;
            }
            else
            {
                return null;
            }
        }


     
    }
}