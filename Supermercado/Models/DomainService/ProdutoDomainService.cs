using Supermercado.Interfaces;
using Supermercado.Models.Entities;
using Supermercado.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Models.DomainService
{
    public class ProdutoDomainService : IProdutoDomainService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoDomainService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Adicionar(FormCadastroMercadoComProdutoViewModel mercadoComProdutoViewModel)
        {
            var produto = new Produto()
            {
                Nome = mercadoComProdutoViewModel.Produto.Nome,
                Preco = mercadoComProdutoViewModel.Produto.Preco,
                
                Mercado = new Mercado() 
                { 
                    Nome = mercadoComProdutoViewModel.Mercado.Nome, 
                    Local = mercadoComProdutoViewModel.Mercado.Local,
                }
            };

            _produtoRepository.Adicionar(produto);
        }

        public IList<Produto> Listar()
        {
            return _produtoRepository.Listar();
        }
    }
}
