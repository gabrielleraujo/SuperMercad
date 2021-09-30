using Supermercado.Models;
using Supermercado.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Interfaces
{
    public interface IMercadoRepository
    {
        IList<Mercado> Listar();
        Mercado BuscarPorId(int mercadoId);
        void Adicionar(Mercado mercado);
        void Atualizar(Mercado mercado);
        void Remover(Mercado mercado);

        IList<Mercado> ListarIncluindoProdutos();
        IList<Produto> ListarProdutos(Mercado mercado);
        Produto BuscarProduto(Mercado mercado, int produtoId);
    }
}
