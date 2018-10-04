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
            model.AssistKey = GetCookie("Canvas.Ecomm.AssistKey"); ;
            model.ShowPopup = GetViewedProductCounter();

            // set Xconnect pageview event


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
            DetailViewModel model = new DetailViewModel(Id);

            // set counter property for popu
            SetViewedProductCounter();

            // check cookie if has AssistKey, use to add to  facet, else generate new
            string _assistKey = null;
            var hasCookiedKey = GetCookie("Canvas.Ecomm.AssistKey");
            if(hasCookiedKey != null)
            {
                _assistKey = hasCookiedKey;
            }
            else
            {
                _assistKey = RandomStrings(6);
                SetCookie("Canvas.Ecomm.AssistKey", _assistKey, false);
            }           
            

            var existingProducts = GetCookie("Canvas.Ecomm.Products");
            if (existingProducts != null)
            {
                existingProducts = existingProducts.Trim() + "," + model.Product.SKU;
                SetCookie("Canvas.Ecomm.Products", existingProducts, true);
            } else
            {
                existingProducts = model.Product.SKU;
                SetCookie("Canvas.Ecomm.Products", existingProducts, true);
            }

            //set xconnect custom facet with product info, using AssistKey
            // Save product viewed to xconnect facet

            //find record
            //if exists, increment view count
            //else add to data
            var uniqueId = string.Format("{0}-{1}-{2}", _assistKey, model.Product.ID, model.Product.SKU);           
            if (DataServices.Exists(uniqueId))
            {
                var drX = DataServices.Find(uniqueId);
                drX.EngagementScore = drX.EngagementScore + 1;
                DataServices.Update(drX);
            } else
            {
                var dr = new DataRecord { ID = uniqueId, AssistKey = _assistKey, Product = model.Product, EngagementScore = 1 };
                DataServices.Add(dr);
            }

           


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
            ProductCustomFacet facet = new ProductCustomFacet();            

            var records = DataServices.UserExperienceData.Where(x=>x.AssistKey.Equals(Id));
            List<string> skus = new List<string>();
            foreach(var record in records)
            {
                skus.Add(record.Product.SKU);
            }

            facet = new ProductCustomFacet
            {
                AssistKey = Id,
                SKU_History = skus.ToList<string>()
            };
         
            

            


            UserProfileViewModel model = new UserProfileViewModel(facet, "User Profile: History");
            return View(model);
        }



        private void SetViewedProductCounter()
        {
            int convertKey = 0;
            var viewed = GetCookie("Canvas.Ecomm.ViewdProducts");
            if (viewed != null)
            {
                convertKey = Convert.ToInt32(viewed);
                convertKey++;
            }
            SetCookie("Canvas.Ecomm.ViewdProducts", convertKey.ToString(), true);
        }

        private bool GetViewedProductCounter()
        {
            bool isThreeProducts = false;
            var viewed = GetCookie("Canvas.Ecomm.ViewdProducts");
            if (viewed != null)
            { 
                if (Convert.ToInt32(viewed) > 1)
                {
                    isThreeProducts = true;
                }
            }          

            return isThreeProducts;
        }

        private string RandomStrings( int length)
        {
            const string allowedChars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rng = new Random();

            char[] chars = new char[length];
            int setLength = allowedChars.Length;
            
            for (int i = 0; i < length; ++i)
            {
                chars[i] = allowedChars[rng.Next(setLength)];
            }
            return new string(chars, 0, length);            
        }

        private string GetCookie(string name)
        {
            if (Request.Cookies[name] != null)
            {
                return Request.Cookies[name].Value.ToString();
            }
            return null;
        }

        private void SetCookie(string name, string val, bool overwrite)
        {
            if (Request.Cookies[name] == null)
            {
                var response = System.Web.HttpContext.Current.Response;
                HttpCookie cookie = new HttpCookie(name);
                cookie.Value = val;
                cookie.Expires = DateTime.Now.AddHours(24);
                response.Cookies.Add(cookie);
            } else
            {
                if(overwrite)
                {
                    var response = System.Web.HttpContext.Current.Response;
                    HttpCookie cookie = new HttpCookie(name);
                    cookie.Value = val;
                    cookie.Expires = DateTime.Now.AddHours(24);
                    response.Cookies.Add(cookie);
                }
            }
        }
    }
}