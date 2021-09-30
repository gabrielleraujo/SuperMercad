using Supermercado.Models.Entities;
using Supermercado.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Interfaces
{
    public interface IMercadoApplicationService
    {
        void Adicionar(FormCadastroMercadoViewModel mercadoViewModel);

        IList<Mercado> Listar();
        public IList<Mercado> ListarIncluindoProdutos();
        public IList<Produto> ListarProdutos(Mercado mercado);
    }
}
