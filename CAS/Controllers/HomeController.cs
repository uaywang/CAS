using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetCasClient;

namespace CAS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            System.Security.Principal.IPrincipal p = HttpContext.User;
            string uid = p.Identity.Name;
            ViewBag.Message = "CAS example works. Your authenticated ID is " + uid;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Abandon();
            CasAuthentication.SingleSignOut();

            ViewBag.Message = "Your logout page.";

            return View();
        }
    }
}