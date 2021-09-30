using Supermercado.Models.Entities;
using Supermercado.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Interfaces
{
    public interface IMercadoDomainService
    {
        void Adicionar(FormCadastroMercadoViewModel mercadoViewModel);

        IList<Mercado> Listar();
        IList<Mercado> ListarIncluindoProdutos();
        IList<Produto> ListarProdutos(Mercado mercado);
    }
}