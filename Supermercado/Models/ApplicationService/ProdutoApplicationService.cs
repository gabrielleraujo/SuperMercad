using Supermercado.Exceptions;
using Supermercado.Interfaces;
using Supermercado.Models.DomainService;
using Supermercado.Models.Entities;
using Supermercado.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Models.DomainService
{
    public class ProdutoApplicationService : IProdutoApplicationService
    {
        private IProdutoDomainService _produtoDomainService;
        public ProdutoApplicationService(IProdutoDomainService produtoDomainService)
        {
            _produtoDomainService = produtoDomainService;
        }

        public void Adicionar(FormCadastroMercadoComProdutoViewModel mercadoComProdutoViewModel)
        {
            MercadoValidationService.Validar(mercadoComProdutoViewModel.Mercado);
            ProdutoValidationService.Validar(mercadoComProdutoViewModel.Produto);

            _produtoDomainService.Adicionar(mercadoComProdutoViewModel);
        }

        public IList<Produto> Listar()
        {
            return _produtoDomainService.Listar();
        }
    }
}