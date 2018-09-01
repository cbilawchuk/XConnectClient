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

            PersonalInformation pi = contact.GetFacet<PersonalInformation>(PersonalInformation.DefaultFacetKey);
            if(pi == null)
            {
                return new ContactViewModel();
            } 

            ContactViewModel model = new ContactViewModel
            {
                Prefix = pi.Title,
                FirstName = pi.FirstName,
                LastName = pi.LastName,
                JobTitle = pi.JobTitle,
                Birthday = (DateTime)pi.Birthdate,
                PreferredLanguage = pi.PreferredLanguage,
                Gender = pi.Gender
            };

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

            _xc.SetPersonalInformationFacet(Source, pi);



            return true;
        }
    }
}