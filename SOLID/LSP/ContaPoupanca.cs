using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    internal class ContaPoupanca : Conta
    {
        public override void Saque(double valor)
        {
            if (Saldo > valor)
            {
                Saldo -= valor;
            }
        }
    }
}
