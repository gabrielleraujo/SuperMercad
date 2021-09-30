using Supermercado.Extencoes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Models.Entities
{
    public class Produto
    {
        private string _nome;

        public Produto()
        {

        }

        [Required]
        public int ProdutoId { get; set; }

        [StringLength(40, ErrorMessage = "{0} deve ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        [Required(ErrorMessage = "{0} é obrigatório")]
        public string Nome
        {
            get { return _nome; }
            set { _nome = value.FirstLetterOfEachWordToUpper(); }
        }

        [Required(ErrorMessage = "{0} é obrigatório")]
        public double Preco { get; set; }

        [Required]
        public Mercado Mercado { get; set; }
    }
}