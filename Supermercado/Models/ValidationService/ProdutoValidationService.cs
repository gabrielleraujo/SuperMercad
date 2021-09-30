using Supermercado.Exceptions;
using Supermercado.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Models.DomainService
{
    public class ProdutoValidationService
    {
        public static void Validar(FormCadastroProdutoViewModel produtoViewModel)
        {
            var erros = new List<string>();

            if (string.IsNullOrEmpty(produtoViewModel.Nome))
            {
                erros.Add("Nome do mercado não informado.");
            }
            if (produtoViewModel.Preco <= 0.00 )
            {
                erros.Add("Produto não pode custar R$0.00.");
            }
            if (erros.Count > 0)
            {
                throw new ListException(erros);
            }
        }
    }
}
