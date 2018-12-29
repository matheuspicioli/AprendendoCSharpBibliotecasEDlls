using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public override bool Equals(object obj)
        {
            // Cast pãdrão (pode lançar uma InvalidCastException)
            // Cliente outroCliente = (Cliente)obj;

            // Cast do C#, outroCliente recebe nulo quando
            // não é possível realizar o cast
            Cliente outroCliente = obj as Cliente;

            if (outroCliente == null)
            {
                return false;
            }

            return CPF == outroCliente.CPF;
        }
    }
}
