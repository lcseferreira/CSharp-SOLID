using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.Heranca
{
    public class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public decimal Saldo { get; protected set; }

        public Conta(int Numero, string Titular)
        {

        }

        public virtual void Depositar(decimal valor)
        {
            if (valor <= 0) throw new ArgumentException(message: "O valor precisa ser maior que 0.");

            Saldo += valor;
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0) throw new ArgumentException(message: "O valor precisa ser maior que 0.");
            if (valor > Saldo) throw new ArgumentException(message: $"Saldo insuficiente. O seu saldo é de {Saldo}");

            Saldo -= valor;
        }


    }
}
