using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            TrabalhandoComString();

            Console.WriteLine("Fim da execução do programa, pressione enter p/ sair");
            Console.WriteLine();
            Console.ReadLine();
        }

        private static void TrabalhandoComString()
        {
            // "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // "[0-9]{4,5}[-][0-9]{4}";
            // "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            // "[0-9]{4,5}-[0-9]{4}";
            // "[0-9]{4,5}-{0,1}[0-9]{4}";
            // ? = {0,1}
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string fraseTeste = "Meu nome é Matheus, me ligue em 99992-7152";

            // Regex.IsMatch(fraseTeste, padrao);
            Match resultado = Regex.Match(fraseTeste, padrao);

            Console.WriteLine(resultado.Value);
            Console.ReadLine();



            // pagina?argumentos
            // 0123456789

            string urlParametros = "http://bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorArgumentosURL extrator = new ExtratorValorArgumentosURL(urlParametros);
            string valor = extrator.GetValor("moedaDestino");
            
            Console.WriteLine(valor);
            Console.ReadLine();
        }

        private static void HoraTempoHumanizer()
        {
            DateTime dataFimPagamento = new DateTime(2018, 8, 17);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(40);

            string mensagem = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);

            Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);
        }
    }
}
