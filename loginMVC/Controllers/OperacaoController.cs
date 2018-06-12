using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loginMVC.Controllers
{
    public class OperacaoController : Controller
    {

        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult EntradaEstoque()
        {
            return View();
        }
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult SaidaEstoque()
        {
            return View();
        }
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult LancPerdaProduto()
        {
            return View();
        }
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult Inventario()
        {
            return View();
        }
    }
}