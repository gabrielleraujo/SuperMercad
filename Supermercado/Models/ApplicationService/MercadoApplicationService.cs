using Supermercado.Exceptions;
using Supermercado.Interfaces;
using Supermercado.Models.DomainService;
using Supermercado.Models.Entities;
using Supermercado.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Models.ApplicationService
{
    public class MercadoApplicationService : IMercadoApplicationService
    {
        private IMercadoDomainService _mercadoDomainService;
        public MercadoApplicationService(IMercadoDomainService mercadoDomainService)
        {
            _mercadoDomainService = mercadoDomainService;
        }

        public void Adicionar(FormCadastroMercadoViewModel mercadoViewModel)
        {
            MercadoValidationService.Validar(mercadoViewModel);
            _mercadoDomainService.Adicionar(mercadoViewModel);
        }

        public IList<Mercado> Listar()
        {
            return _mercadoDomainService.Listar();
        }

        public IList<Mercado> ListarIncluindoProdutos()
        {
            return _mercadoDomainService.ListarIncluindoProdutos();
        }

        public IList<Produto> ListarProdutos(Mercado mercado)
        {
            return _mercadoDomainService.ListarProdutos(mercado);
        }
    }
}
