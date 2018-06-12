using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loginMVC.Controllers
{
    public class CadastroController : Controller
    {
       //Authorize Para acessar tem que estar logado
       //com autorização
       [Authorize]
        public ActionResult GrupoProduto()
        {
            return View();
        }
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult MarcaProduto()
        {
            return View();
        }
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult LocalProduto()
        {
            return View();
        }
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult UnidadeMedida()
        {
            return View();
        }
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult Produto()
        {
            return View();
        }
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult Pais()
        {
            return View();
        }
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult Estado()
        {
            return View();
        }
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult Cidade()
        {
            return View();
        }
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult Fornecedor()
        {
            return View();
        }
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult PerfilUsuario()
        {
            return View();
        }
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult Usuario()
        {
            return View();
        }

    }
}