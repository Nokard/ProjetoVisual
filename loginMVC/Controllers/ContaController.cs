using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loginMVC.Controllers
{
    public class ContaController : Controller
    {
        
        //Permite que todo mundo acesse essa página
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            //USAMOS returnUrl para voltar na pagina que tentou acessar
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
    }
}