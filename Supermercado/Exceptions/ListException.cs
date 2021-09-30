using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Exceptions
{
    public class ListException : Exception
    {
        public readonly IList<string> MessageList;

        public ListException(IList<string> mensagensDeErro)
        {
            MessageList = mensagensDeErro;
        }

        public ListException() { }
        public ListException(string mensagem) : base(mensagem) { }
        public ListException(string mensagem, Exception inner) : base(mensagem, inner) { }
    }
}
