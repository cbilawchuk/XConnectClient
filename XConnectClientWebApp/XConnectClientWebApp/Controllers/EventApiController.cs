using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XConnectClientWebApp.Models;
using XConnectClientWebApp.Services;
using XConnectClientServices.Services;

namespace XConnectClientWebApp.Controllers
{
    public class EventApiController : ApiController
    {
        private ContactServices _cservice;


        public EventApiController()
        {
            _cservice = new ContactServices();
        }

        // GET api/Employees
        public IEnumerable<string> Get()
        {
            //there is no listing of event visotrs
            return null;
        }

        // POST api/Employees
        public string Post(EventVisitor data)
        {          
            if(data.SourceId != null)
            {
                var visitor = data;

                ContactViewModel model = new ContactViewModel
                {
                    SourceId = data.SourceId,
                    FirstName = data.FirstName,
                    LastName = data.LastName,
                    Email = data.EmailAddress,
                    EmailType = "Work",
                    Company = data.Company,
                    AvatarImage = data.Avatar64,
                    JobTitle = data.Title
                };


                var results = _cservice.SetContactDetails(data.SourceId, model);
                _cservice.SetAvatarPicture(model.SourceId, Convert.FromBase64String(model.AvatarImage));

                

                return visitor.SourceId;
            }
            return null; 
        }

        // GET api/Employees/5
        public EventVisitor Get(string id)
        {
            // fetch EventVistor by id and rerturn object

            EventVisitor data = new EventVisitor()
            {
                SourceId = id
            };
            return data;
        }

    }
}
