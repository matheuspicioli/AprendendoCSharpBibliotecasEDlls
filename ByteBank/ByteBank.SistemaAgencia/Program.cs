using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(0001,7687150);

            // FuncionarioAutenticavel implementa a AutenticacaoHelper
            // no mesmo projeto, portanto não temos erros aqui
            FuncionarioAutenticavel carlos = null;
            carlos.Autenticar("testesenha");

            // AutenticacaoHelper é uma classe interna
            // portanto não pode ser instanciada fora
            // de seu projeto inicial
            //AutenticacaoHelper autenticacao = new AutenticacaoHelper();
            //autenticacao.CompararSenhas("senha true","senha false");

            Console.WriteLine(conta.Numero);
            Console.ReadLine();
        }
    }
}
