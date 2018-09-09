using System.Web.Mvc;
using System.Web.Security;
using XConnectClientWebApp.Models;
using XConnectClientWebApp.Services;
using XConnectClientServices.Services;
using XConnectClientServices;

namespace XConnectClientWebApp.Controllers
{
    public class HomeController : Controller
    {
        private XConnectClientService _xc;

        public HomeController()
        {
            _xc = new XConnectClientService();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                if (user.IsValid(user.UserName, user.Password))
                {

                    var userId = Security.ComputeMD5(user.UserName);

                    FormsAuthentication.SetAuthCookie(userId, user.RememberMe);

                    _xc.SetPageViewEvent(userId, System.Web.HttpContext.Current.Request);


                    return RedirectToAction("Index", "App");
                }
                else
                {
                    ModelState.AddModelError("", "Login data is incorrect!");
                }
            }
            return View("Index", user);
        }
        public ActionResult Logout()
        {
            var userId = Security.ComputeMD5(User.Identity.Name);
            _xc.SetPageViewEvent(userId, System.Web.HttpContext.Current.Request);

            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}