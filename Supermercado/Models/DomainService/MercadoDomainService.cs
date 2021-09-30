using Supermercado.Extencoes;
using Supermercado.Interfaces;
using Supermercado.Models.Entities;
using Supermercado.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Models.DomainService
{
    public class MercadoDomainService : IMercadoDomainService
    {
        private readonly IMercadoRepository _mercadoRepository;

        public MercadoDomainService(IMercadoRepository mercadoRepository)
        {
            _mercadoRepository = mercadoRepository;
        }

        public void Adicionar(FormCadastroMercadoViewModel mercadoViewModel)
        {
            var mercado = new Mercado()
            {
                Nome = mercadoViewModel.Nome,
                Local = mercadoViewModel.Local,
            };

            _mercadoRepository.Adicionar(mercado);
        }

        public IList<Mercado> Listar()
        {
            return _mercadoRepository.Listar();
        }

        public IList<Mercado> ListarIncluindoProdutos()
        {
            return _mercadoRepository.ListarIncluindoProdutos();
        }

        public IList<Produto> ListarProdutos(Mercado mercado)
        {
            return _mercadoRepository.ListarProdutos(mercado);
        }
    }
}
