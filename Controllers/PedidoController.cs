﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodigoStore.Controllers
{
    public class PedidoController : Controller
    {

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Carrinho()
        {
            return View();
        }

        public IActionResult Carrossel()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            return View();
        }


    }
}