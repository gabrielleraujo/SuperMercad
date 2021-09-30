using Supermercado.Interfaces;
using Supermercado.Models;
using Supermercado.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Repository.EntityFrameworkCore
{
    public class ProdutoRepository : IProdutoRepository
    {
        private SupermercadoDbContext _context;

        public ProdutoRepository(SupermercadoDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Atualizar(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }

        public Produto BuscarPorId(int produtoId)
        {
            return _context.Produtos.Where(p => p.ProdutoId == produtoId).FirstOrDefault();
        }

        public IList<Produto> Listar()
        {
            return _context.Produtos.ToList();
        }

        public void Remover(Produto produto)
        {
            _context.SaveChanges();
        }
    }
}
