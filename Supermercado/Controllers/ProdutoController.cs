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
    public class ProdutoController : Controller
    {
        private readonly IProdutoApplicationService _produtoApplicationService;

        public ProdutoController(
            IProdutoApplicationService produtoApplicationService)
        {
            _produtoApplicationService = produtoApplicationService;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            IList<Produto> mercados;
            try
            {
                mercados = _produtoApplicationService.Listar();
            }
            catch (Exception e)
            {
                return RedirectToAction("SystemError", "Erro", e);
            }
            return View(Views.BuscarSubPasta(ControllerContext, "Lista"), mercados);
        }


        public IActionResult FormCadastro(FormCadastroMercadoComProdutoViewModel mercadoComProdutoViewModel)
        {
            return View(Views.BuscarSubPasta(ControllerContext, "Adiciona"), mercadoComProdutoViewModel);
        }

        public IActionResult Adicionar(FormCadastroMercadoComProdutoViewModel mercadoComProdutoViewModel)
        {
            try
            {
                _produtoApplicationService.Adicionar(mercadoComProdutoViewModel);
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
