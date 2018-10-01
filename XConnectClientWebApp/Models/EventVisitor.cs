using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XConnectClientWebApp.Models
{
    public class EventVisitor
    {
        public string SourceId { get; set; }
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Company { get; set; }
        public string Relationship { get; set; }

        public string Avatar64 { get; set; }
        public string Badge64 { get; set; }
        public string Title { get; set; }

        public string Name
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }
}