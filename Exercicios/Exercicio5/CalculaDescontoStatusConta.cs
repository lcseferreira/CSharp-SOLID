using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicio5
{
    internal class CalculaDescontoStatusConta : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco, decimal descontoCliente)
        {
            decimal descontoPorStatusConta = preco - (descontoCliente - preco);

            return descontoPorStatusConta;
        }
    }
}
