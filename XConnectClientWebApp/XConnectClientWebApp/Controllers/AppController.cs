using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XConnectClientWebApp.Models;
using XConnectClientWebApp.Services;

namespace XConnectClientWebApp.Controllers
{
    public class AppController : Controller
    {
        private ContactServices _cservice;
        private XConnectClientService _xc;

        public AppController()
        {
            _cservice = new ContactServices();
            _xc = new XConnectClientService();
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Dashboard";

            _xc.SetPageViewEvent(User.Identity.Name);
            ContactViewModel model = _cservice.GetContactDetails(User.Identity.Name);

            return View(model);
        }

      
        public ActionResult About()
        {
            _xc.SetPageViewEvent(User.Identity.Name);
            return View();
        }

        public ActionResult Contact()
        {
            _xc.SetPageViewEvent(User.Identity.Name);
            return View();
        }
    }
}