using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loginMVC.Controllers
{
    public class RelatorioController : Controller
    {
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult PosicaoEstoque()
        {
            return View();
        }
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult Ressuprimento()
        {
            return View();
        }
    }
}