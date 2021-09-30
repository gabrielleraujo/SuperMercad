using Supermercado.Models;
using Supermercado.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Supermercado.Interfaces;

namespace Supermercado.Repository.EntityFrameworkCore
{
    public class MercadoRepository : IMercadoRepository
    {
        private SupermercadoDbContext _context;

        public MercadoRepository(SupermercadoDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Mercado mercado)
        {
            _context.Mercados.Add(mercado); // erro aqui. (estava faltando o .Mercados antes do .Add)
            _context.SaveChanges();
        }

        public void Atualizar(Mercado mercado)
        {
            _context.Mercados.Update(mercado);
            _context.SaveChanges();
        }

        public Mercado BuscarPorId(int mercadoId)
        {
            return _context.Mercados.Where(m => m.MercadoId == mercadoId).FirstOrDefault();
        }

        public IList<Mercado> Listar()
        {
            return _context.Mercados.ToList();
        }

        public void Remover(Mercado mercado)
        {
            _context.Mercados.Remove(mercado);
            _context.SaveChanges();
        }

        public IList<Mercado> ListarIncluindoProdutos()
        {
            var mercadoDb = _context
                .Mercados
                .Include(m => m.Produtos)
                .ToList();
            return mercadoDb;
        }

        public Produto BuscarProduto(Mercado mercado, int produtoId)
        {
            var produtos = ListarProdutos(mercado);
            return produtos.Where(p => p.ProdutoId == produtoId).SingleOrDefault();
        }

        public IList<Produto> ListarProdutos(Mercado mercado)
        {
            var mercadoDb = _context
                .Mercados
                .Include(m => m.Produtos)
                .Where(m => m.MercadoId == mercado.MercadoId)
                .FirstOrDefault();
            return mercadoDb.Produtos;
        }
    }
}
