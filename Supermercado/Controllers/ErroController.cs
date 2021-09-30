using Microsoft.AspNetCore.Mvc;
using Supermercado.Models.ViewModels;
using Supermercado.Models.ViewModels.ErrorViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Controllers
{
    public class ErroController : Controller
    {
        public IActionResult ListError(ListErrorViewModel _erros)
        {
            return View(_erros);
        }

        public IActionResult SystemError(Exception erro)
        {
            return View(erro);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
