﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loginMVC.Controllers
{
    public class GraficoController : Controller
    {
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult PerdaMes()
        {
            return View();
        }
        //Authorize Para acessar tem que estar logado
        //com autorização
        [Authorize]
        public ActionResult EntradaSaidaMes()
        {
            return View();
        }
    }
}