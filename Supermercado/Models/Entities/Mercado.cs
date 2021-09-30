using Supermercado.Extencoes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Models.Entities
{
    // C:\Users\User\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\mssqllocaldb
    public class Mercado
    {
        private string _nome;
        private string _local;

        public Mercado()
        {

        }

        [Required]
        public int MercadoId { get; set; }

        [StringLength(40, ErrorMessage = "{0} deve ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        [Required(ErrorMessage = "{0} é obrigatório")]
        public string Nome 
        {
            get { return _nome; }
            set { _nome = value.FirstLetterOfEachWordToUpper(); } 
        }
        
        [Required(ErrorMessage = "{0} é obrigatório")]
        public string Local
        {
            get { return _local; }
            set { _local = value.ToUpper(); }
        }

        [Required]
        public IList<Produto> Produtos { get; set; }
    }
}
