using Supermercado.Exceptions;
using Supermercado.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Models.DomainService
{
    public static class MercadoValidationService
    {
        public static void Validar(FormCadastroMercadoViewModel mercadoViewModel)
        {
            var erros = new List<string>();

            if (string.IsNullOrEmpty(mercadoViewModel.Nome))
            {
                erros.Add("Nome do mercado não informado.");
            }
            if (string.IsNullOrEmpty(mercadoViewModel.Local))
            {
                erros.Add("Nome do Local não informado.");
            }
            if (erros.Count > 0)
            {
                throw new ListException(erros);
            }
        }
    }
}
