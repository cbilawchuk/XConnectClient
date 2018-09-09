using StaticSite.Models;
using StaticSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XConnectClientServices;
using XConnectClientServices.Services;

namespace StaticSite.Controllers
{
    public class HomeController : Controller
    {

        private ContactServices _cservice;
        private XConnectClientService _xc;

        public HomeController()
        {
            _cservice = new ContactServices();
            _xc = new XConnectClientService();
        }


        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Studio()
        {
            return View();
        }

        [HttpGet]
        public ActionResult FAQs()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Subscribe(Subscribe data)
        {
            var source = Security.ComputeMD5(data.emailAddress);
            _xc.SetPageViewEvent(User.Identity.Name, System.Web.HttpContext.Current.Request);
            _cservice.SubscribeContact(source, data);

            return View("Index", data);
        }

    }
}