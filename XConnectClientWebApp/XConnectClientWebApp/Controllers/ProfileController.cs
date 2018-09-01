using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using XConnectClientWebApp.Models;
using XConnectClientWebApp.Services;

namespace XConnectClientWebApp.Controllers
{
    public class ProfileController : Controller
    {
        private ContactServices _cservice;
        private XConnectClientService _xc;

        public ProfileController()
        {
            _cservice = new ContactServices();
            _xc = new XConnectClientService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "List of contacts in XConnect."; 
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Title = "Create";
            ViewBag.Message = "Create a new contact.";
            return View(new ContactViewModel());
        }

        [HttpPost]
        public ActionResult Create(ContactViewModel model)
        {
            ViewBag.Title = "Create";
            ViewBag.Message = "Create a new contact.";

            try
            {
                //_xconnect.CreateContact(Guid.NewGuid().ToString(), model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            };
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            ViewBag.Title = "Edit";
            ViewBag.Message = "Viewing contact: " + User.Identity.Name;

            _xc.SetPageViewEvent(User.Identity.Name);

            ContactViewModel model = _cservice.GetContactDetails(User.Identity.Name);

            return View(model);
        }


        [HttpPost]
        public ActionResult Edit(string id, ContactViewModel model)
        {
            ViewBag.Title = "Edit";
            ViewBag.Message = "Viewing contact: " + User.Identity.Name;

            try
            {              
                _xc.SetPageViewEvent(User.Identity.Name);

                var results = _cservice.SetContactDetails(User.Identity.Name, model);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View(model);
            };
        }


        [HttpGet]
        public ActionResult Upload(string Id)
        {
            ViewBag.Title = "Upload";
            ViewBag.Message = "Upload a profile image.";

            ContactViewModel model = new ContactViewModel(); // _xconnect.GetContactBySource(Id);

            return View(model);
        }


        [HttpPost]
        public ActionResult Upload(string id, ContactViewModel model)
        {
            ViewBag.Title = "Upload";
            ViewBag.Message = "Upload a profile image.";

            try
            {
                // TODO: Add insert logic here
                //ContactViewModel model = new XconnectClientService().TestClient();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            };
        }


    }
}