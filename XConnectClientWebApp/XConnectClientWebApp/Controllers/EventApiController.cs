using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XConnectClientWebApp.Models;

namespace XConnectClientWebApp.Controllers
{
    public class EventApiController : ApiController
    {
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
