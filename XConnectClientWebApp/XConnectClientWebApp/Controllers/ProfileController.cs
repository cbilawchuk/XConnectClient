using System;
using System.IO;
using System.Threading.Tasks;
using System.Web;
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
            ViewBag.Title = "Profile";
           
            _xc.SetPageViewEvent(User.Identity.Name);

            ContactViewModel model = _cservice.GetContactDetails(User.Identity.Name);

            return View(model);
        }


        [HttpGet]
        public ActionResult Edit(string id)
        {
            ViewBag.Title = "Edit";
            ViewBag.Message = "Editing contact: " + User.Identity.Name;

            _xc.SetPageViewEvent(User.Identity.Name);

            ContactViewModel model = _cservice.GetContactDetails(id);

            return View(model);
        }


        [HttpPost]
        public ActionResult Edit(string id, ContactViewModel model)
        {
            ViewBag.Title = "Edit";
         
            try
            {              
               // _xc.SetPageViewEvent(User.Identity.Name);

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


        public ActionResult FileUpload(HttpPostedFileBase file)
        {
            var Source = User.Identity.Name;

            if (file != null)
            {
                string pic = Source + "." + System.IO.Path.GetExtension(file.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/images/profile"), pic);
                // file is uploaded
                file.SaveAs(path);

                using (MemoryStream ms = new MemoryStream())
                {
                    file.InputStream.CopyTo(ms);
                    byte[] array = ms.GetBuffer();

                    // update image
                    _cservice.SetAvatarPicture(Source, array);

                    
                }

            }
            // after successfully uploading redirect the user
            return RedirectToAction("Index");
        }


    }
}