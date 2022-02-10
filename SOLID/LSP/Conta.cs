using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    internal class Conta
    {
        public double Saldo { get; set; }

        public virtual void Saque(double valor)
        {
            Saldo -= valor;
        }
    }
}
