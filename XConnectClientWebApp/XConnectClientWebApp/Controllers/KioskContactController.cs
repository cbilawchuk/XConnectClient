using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace XConnectClientWebApp.Controllers
{
    public class KioskContactController : ApiController
    {
        // GET api/Employees
        public IEnumerable<string> Get()
        {
            List<string> data = null;
            // Get here the list of employees
            return data;
        }

        // POST api/Employees
        public string Post(string field)
        {
            
            return field; 
        }

        // GET api/Employees/5
        public string Get(int id)
        {
            string data = "debug get(" + id.ToString() + ")";
            // Get here the employee with the id
            return data;
        }

        // PUT api/Employees/5
        public string Put(int id, string data)
        {
            
            return data + " ==> " + id.ToString();        }

    }
}
