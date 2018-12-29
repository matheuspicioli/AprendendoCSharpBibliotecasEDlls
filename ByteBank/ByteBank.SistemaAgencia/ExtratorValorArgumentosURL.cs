using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }
        public ExtratorValorArgumentosURL(string url)
        {
            if(String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vázio", nameof(url));
            }

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

            URL = url;
        }

        // moedaOrigem=real&moedaDestino=dolar
        // MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR
        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper(); // VALOR
            string argumentosEmCaixaAlta = _argumentos.ToUpper(); // MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR

            string termo = nomeParametro + "="; // moedaDestino=
            int indice = argumentosEmCaixaAlta.IndexOf(termo);

            string resultado = _argumentos.Substring(indice + termo.Length); // dolar
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);
        }
    }
}
