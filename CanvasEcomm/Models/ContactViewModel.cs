using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CanvasEcomm.Models
{
    public class ContactViewModel
    {
        public string SourceId { get; set; }

        public string Email { get; set; }
        public string EmailType { get; set; }

        public string PhoneNumber { get; set; }
        public string PhoneNumberType { get; set; }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public string AvatarImage { get; set; }
        public DateTime Birthday { get; set; }
        public string JobTitle { get; set; }
        public string Nickame { get; set; }
        public string Prefix { get; set; }
        public string Title { get; set; }
        public string PreferredLanguage { get; set; }


        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }

        public string Name {
            get
            {
                if(this.LastName != null && !this.LastName.Equals(""))
                {
                    return string.Format("{0} {1}", this.FirstName, this.LastName);
                } else
                {
                    return "Unknown";
                }
                
            }
        }


        public IEnumerable<SelectListItem> EmailTypeList
        {
            get { return new SelectList(
                new List<SelectListItem>
                {
                    new SelectListItem { Selected = true, Text = "Work", Value = "Work"},
                    new SelectListItem { Selected = false, Text = "Home", Value = "Home"},

                }, "Value", "Text", 1);
            }
        }

        public IEnumerable<SelectListItem> Honorific
        {
            get
            {
                return new SelectList(
              new List<SelectListItem>
              {
                    new SelectListItem { Selected = true, Text = "(Prefix...)", Value = ""},
                    new SelectListItem { Selected = false, Text = "Mr.", Value = "Mr"},
                    new SelectListItem { Selected = false, Text = "Mrs.", Value = "Mrs"},
                    new SelectListItem { Selected = false, Text = "Ms.", Value = "Ms"},
                    new SelectListItem { Selected = false, Text = "Miss.", Value = "Miss"},

              }, "Value", "Text", 1);
            }
        }

        public IEnumerable<SelectListItem> PreferredLanguageList
        {
            get
            {
                return new SelectList(
              new List<SelectListItem>
              {
                    new SelectListItem { Selected = true, Text = "(Language...)", Value = ""},
                    new SelectListItem { Selected = false, Text = "English", Value = "EN"},
                    new SelectListItem { Selected = false, Text = "French", Value = "FR"},
                    new SelectListItem { Selected = false, Text = "Spanish", Value = "ES"}

              }, "Value", "Text", 1);
            }
        }

        public IEnumerable<SelectListItem> GenderList
        {
            get
            {
                return new SelectList(
              new List<SelectListItem>
              {
                    new SelectListItem { Selected = true, Text = "(Gender...)", Value = ""},
                    new SelectListItem { Selected = false, Text = "Male", Value = "Male"},
                    new SelectListItem { Selected = false, Text = "Female", Value = "Female"}

              }, "Value", "Text", 1);
            }
        }
    }
}