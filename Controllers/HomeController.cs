using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace QRCard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Tu Duży. Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }


    }
}
