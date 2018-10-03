using CanvasEcomm.Models;
using CanvasEcomm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XConnectClientServices.Services;

namespace CanvasEcomm.Controllers
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

        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.ShowPopup = GetViewedProductCounter();
            return View(model);
        }

        [HttpGet]
        public ActionResult Men()
        {

            PageViewModel model = new PageViewModel("Men","Men's Clothing", "Clothing for men");
            return View(model);
        }

        [HttpGet]
        public ActionResult Women()
        {
            PageViewModel model = new PageViewModel("Women", "Womens's Dresses", "Pretty dresses for women");
            return View(model);
        }

        [HttpGet]
        public ActionResult Accessories()
        {
            PageViewModel model = new PageViewModel("Accessories", "Amazing Accessories", "All the extra stuff");
            return View(model);
        }

        [HttpGet]
        public ActionResult Sale()
        {
            PageViewModel model = new PageViewModel("Sale", "Items on Sale", "A variety of things");
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(string Id)
        {
            SetViewedProductCounter();

            DetailViewModel model = new DetailViewModel(Id);
            return View(model);
        }


        [HttpGet]
        public ActionResult UserProfile(string Id)
        {
            // Get Research History   // 

            // Show product attribute counts
            // Color, Size, Classification eg: Watch (3), Blue (2)

            // Show signups to studio site
            // Show analytics info


            ProductCustomFacet facet = new ProductCustomFacet
            {
                AccountID = Id,
                SKU_History = new List<string> { "10001ABC-10", "10001ABC-09", "10001ABC-03", "10001ABC-01" }
            };

            


            UserProfileViewModel model = new UserProfileViewModel(facet, "User Profile: History");
            return View(model);
        }



        private void SetViewedProductCounter()
        {
            int convertKey = 0;
            if (Session["hasViewedProduct"] != null)
            {
                //Converting your session variable value to integer
                convertKey = Convert.ToInt32(Session["hasViewedProduct"]);
                convertKey++;
            }
            Session["hasViewedProduct"] = convertKey;
        }

        private bool GetViewedProductCounter()
        {
            bool isThreeProducts = false;
            if (Session["hasViewedProduct"] != null)
            {
                if (Convert.ToInt32(Session["hasViewedProduct"]) > 1)
                {
                    isThreeProducts = true;
                }
            }          

            return isThreeProducts;
        }
    }
}