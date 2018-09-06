using Sitecore.XConnect;
using Sitecore.XConnect.Collection.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XConnectClientWebApp.Models;

namespace XConnectClientWebApp.Services
{
    public class ContactServices
    {
        public ContactViewModel GetContactDetails(string Source)
        {
            XConnectClientService _xc = new XConnectClientService();

            // Get or Create a new contact
            Contact contact = _xc.GetOrSetContact(Source);


            if (contact == null)
            {
                return new ContactViewModel
                {
                    SourceId = Source
                };
            }

            PersonalInformation pi = contact.GetFacet<PersonalInformation>(PersonalInformation.DefaultFacetKey);
            EmailAddressList el = contact.GetFacet<EmailAddressList>(EmailAddressList.DefaultFacetKey);
            AddressList al = contact.GetFacet<AddressList>(AddressList.DefaultFacetKey);
            Avatar a = contact.GetFacet<Avatar>(Avatar.DefaultFacetKey);
                       
            ContactViewModel model = new ContactViewModel();
            model.SourceId = Source;

            if (pi != null)
            {
                model.Prefix = pi.Title;
                model.FirstName = pi.FirstName;
                model.LastName = pi.LastName;
                model.JobTitle = pi.JobTitle;
                model.Birthday = (DateTime)pi.Birthdate;
                model.PreferredLanguage = pi.PreferredLanguage;
                model.Gender = pi.Gender;
            }

            if (el != null)
            {
                model.Email = el.PreferredEmail.SmtpAddress;
                model.EmailType = el.PreferredKey;
            }

            if (al != null)
            {
                model.AddressLine1 = al.PreferredAddress.AddressLine1;
                model.AddressLine2 = al.PreferredAddress.AddressLine2;
                model.City = al.PreferredAddress.City;
                model.State = al.PreferredAddress.StateOrProvince;
                model.CountryCode = al.PreferredAddress.CountryCode;
                model.PostalCode = al.PreferredAddress.PostalCode;
            }

            
            if (a?.Picture != null)
            {
                model.AvatarImage = string.Format("data:image/jpeg;base64, {0}", Convert.ToBase64String(a.Picture));
            }



            return model;
        }


        public bool SetContactDetails(string Source, ContactViewModel model)
        {
            XConnectClientService _xc = new XConnectClientService();

            // Get or Create a new contact
            Contact contact = _xc.GetOrSetContact(Source);


            PersonalInformation pi = new PersonalInformation
            {
                Title = model.Prefix,
                FirstName = model.FirstName,
                LastName = model.LastName,
                JobTitle = model.JobTitle,
                Birthdate = model.Birthday,
                PreferredLanguage = model.PreferredLanguage,
                Gender = model.Gender
            };

            // create a preferred email address since this is just one
            EmailAddress pe = new EmailAddress(model.Email, true);

            // add email to an email facet (List)
            EmailAddressList el = new EmailAddressList(pe, model.EmailType);

            PhoneNumber ph = new PhoneNumber(model.CountryCode, model.PhoneNumber);

            PhoneNumberList pl = new PhoneNumberList(ph, model.PhoneNumberType);

            Address a = new Address
            {
                AddressLine1 = model.AddressLine1,
                AddressLine2 = model.AddressLine2,
                City = model.City,
                StateOrProvince = model.State,
                CountryCode = model.CountryCode,
                PostalCode = model.PostalCode
            };

            AddressList al = new AddressList(a, model.EmailType);  // Using emailType =='Work' since don't have a address type in model.

            _xc.SetPersonalInformationFacet(Source, pi);

            _xc.SetEmailListFacet(Source, el);

            _xc.SetPhoneListFacet(Source, pl);

            //_xc.SetAddressListFacet(Source, al);

            return true;
        }


        public bool SetAvatarPicture(string Source, byte[] array)
        {
            XConnectClientService _xc = new XConnectClientService();

            Avatar avatarFacet = new Avatar(string.Empty, new byte[] { });
            if (array != null)
            {
                avatarFacet.MimeType = "image/jpg";
                avatarFacet.Picture = array; // Convert.FromBase64String(image64);
            }

            _xc.SetAvatarFacet(Source, avatarFacet);

            return true;
        }
    }
}