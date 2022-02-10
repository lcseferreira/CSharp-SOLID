using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicio5
{
    internal interface ICalculaDescontoStatusConta
    {
        decimal AplicarDescontoStatusConta(decimal preco, decimal descontoCliente);
    }
}
