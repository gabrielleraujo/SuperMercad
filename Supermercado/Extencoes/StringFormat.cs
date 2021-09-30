using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Extencoes
{
    public static class StringFormat
    {
        public static string FirstLetterOfEachWordToUpper(this string texto)
        {
            string[] palavras = texto.Split(' ');
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder(texto);

            int posicao = 0;
            foreach (var palavra in palavras)
            {
                if (posicao < texto.Length)
                {
                    stringBuilder[posicao] = char.ToUpper(texto[posicao]);
                    posicao += (palavra.Length) + 1;
                }
            }
            return stringBuilder.ToString();
        }
    }
}
