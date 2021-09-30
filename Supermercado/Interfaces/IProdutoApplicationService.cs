using Supermercado.Models.Entities;
using Supermercado.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Interfaces
{
    public interface IProdutoApplicationService
    {
        void Adicionar(FormCadastroMercadoComProdutoViewModel mercadoComProdutoViewModel);

        IList<Produto> Listar();
    }
}
