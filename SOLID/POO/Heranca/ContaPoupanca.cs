using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.POO.Heranca
{
    // Classe derivada (subclasse ou classe filha)
    public class ContaPoupanca : Conta
    {
        private decimal _jurosMensais = 0.05M;

        public ContaPoupanca(int numero, decimal saldo) : base(numero, saldo)
        {
            Console.WriteLine("Construtor da classe filha");
        }

        // readonly
        public decimal JurosMensais { get => _jurosMensais; }

        // Sobrescrevendo o método GetSaldo
        public override decimal GetSaldo()
        {
            // Chamando um método da classe base
            base.GetSaldo();

            Saldo += Saldo * _jurosMensais;

            return Saldo;
        }

    }
}
