using System.Web.Mvc;
using System.Web.Security;
using XConnectClientWebApp.Models;
using XConnectClientWebApp.Services;

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
                    FormsAuthentication.SetAuthCookie(user.UserName, user.RememberMe);

                    _xc.SetPageViewEvent(user.UserName);


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
            _xc.SetPageViewEvent(User.Identity.Name);

            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}