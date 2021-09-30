using Supermercado.Models.Entities;
using Supermercado.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Interfaces
{
    public interface IProdutoDomainService
    {
        void Adicionar(FormCadastroMercadoComProdutoViewModel mercadoComProdutoViewModel);
        
        public IList<Produto> Listar();
    }
}
