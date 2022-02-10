using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.POO.Heranca
{
    // Classe base (superclasse ou classe pai)
    public class Conta
    {
        // Propriedades
        public int Numero { get; private set; }
        public decimal Saldo { get; protected set; }

        // Construtores
        public Conta()
        {

        }

        public Conta(int numero, decimal saldo)
        {
            Numero = numero;
            Saldo = saldo;

            Console.WriteLine("Construtor da classe pai");
        }

        // Método que será sobreposto
        public virtual decimal GetSaldo()
        {
            Console.WriteLine("Testando chamada");
            return Saldo;
        }
    }
}
