using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loginMVC.Controllers
{
    public class HomeController : Controller
    {
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult Sobre()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

              
    }
}