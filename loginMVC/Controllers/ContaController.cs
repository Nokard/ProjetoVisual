using loginMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

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


        //Recebendo um post da LoginViewModel que está vindo da view Conta/Login
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel login, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            //ValidarUsuario é uma Classe que faz a verificacao no Banco de Dados 
            // e retorna o Usuario e a Senha para essa classe
                var AchouDadosUsuario = UsuarioModel.ValidarUsuario(login.Usuario, login.Senha);

                if (AchouDadosUsuario)
                {
                    FormsAuthentication.SetAuthCookie(login.Usuario, login.LembrarMe);
                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        RedirectToAction("Produto", "Cadastro");
                    }

                }
                else
                {
                    ModelState.AddModelError("", "Login Inválido. ");
                }
            
            
            return View(login);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Home");
        }
    }
}