using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Supermercado.Exceptions;
using Supermercado.Controllers.Extencoes;
using Supermercado.Models;
using Supermercado.Models.Entities;
using Supermercado.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Supermercado.Models.ViewModels.ErrorViewModel;
using Supermercado.Interfaces;

namespace Supermercado.Controllers
{
    public class MercadoController : Controller
    {
        private readonly IMercadoApplicationService _mercadoApplicationService;
        
        public MercadoController(
            IMercadoApplicationService mercadoApplicationService)
        {
            _mercadoApplicationService = mercadoApplicationService;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            IList<Mercado> mercados;
            try
            {
                mercados = _mercadoApplicationService.Listar();
            }
            catch (Exception e)
            {
                return RedirectToAction("SystemError", "Erro", e);
            }
            return View(Views.BuscarSubPasta(ControllerContext, "Lista"), mercados);
        }

        public IActionResult ListarIncluindoProdutos()
        {
            IList<Mercado> mercados;
            try
            {
                mercados = _mercadoApplicationService.ListarIncluindoProdutos();
            }
            catch (Exception e)
            {
                return RedirectToAction("SystemError", "Erro", e);
            }
            return View(Views.BuscarSubPasta(ControllerContext, "Lista"), mercados);
        }

        public IActionResult FormCadastro()
        {
            return View(Views.BuscarSubPasta(ControllerContext, "Adiciona"));
        }
        
        public IActionResult FormCadastroComProduto()
        {
            return View(Views.BuscarSubPasta(ControllerContext, "Adiciona"));
        }
        
        [HttpPost]
        public IActionResult Adicionar(FormCadastroMercadoViewModel mercadoViewModel)
        {
            try
            {
                _mercadoApplicationService.Adicionar(mercadoViewModel);
            }
            catch (ListException e)
            {
                var erros = new ListErrorViewModel() { Erros = e.MessageList };
                return RedirectToAction("ListError", "Erro", erros);
            }
            catch (Exception e)
            {
                return RedirectToAction("SystemError", "Erro", e);
            }
            return View(Views.BuscarSubPasta(ControllerContext, "Adiciona"));
        }
    }
}
