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
        private XConnectClientService _xc;

        public AppController()
        {
            _xc = new XConnectClientService();
        }

        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult Dashboard()
        {
            _xc.SetPageViewEvent(User.Identity.Name);
            return View();
        }

        public ActionResult UserProfile()
        {
            _xc.SetPageViewEvent(User.Identity.Name);
            return View();
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