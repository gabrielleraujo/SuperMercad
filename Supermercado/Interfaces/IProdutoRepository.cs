using Supermercado.Models;
using Supermercado.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Interfaces
{
    public interface IProdutoRepository
    {
        IList<Produto> Listar();
        Produto BuscarPorId(int produtoId);
        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
        void Remover(Produto produto);
    }
}
