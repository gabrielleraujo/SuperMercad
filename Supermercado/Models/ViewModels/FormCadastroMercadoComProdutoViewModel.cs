using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermercado.Models.Entities;
using Supermercado.Models.ViewModels;

namespace Supermercado.Models.ViewModels
{
    public class FormCadastroMercadoComProdutoViewModel
    {
        public FormCadastroMercadoViewModel Mercado { get; set; }
        public FormCadastroProdutoViewModel Produto { get; set; }
    }
}