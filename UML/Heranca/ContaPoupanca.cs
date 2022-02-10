using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.Heranca
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int Numero, string Titular) : base(Numero, Titular)
        {
        }

        public DateTime DataAniversario { get; set; }
        public decimal Rendimentos { get; private set; }

        public void CreditoJuros(decimal valor)
        {
            Saldo += valor;
        }
    }
}
