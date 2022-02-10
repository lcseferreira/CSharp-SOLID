using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicio5
{
    internal class GerenciadorDeDesconto
    {
        public decimal AplicarDesconto(decimal precoProduto, int statusContaCliente, int tempoDaContaEmAnos)
        {
            decimal precoAposDesconto = 0;
            decimal descontPorFidelidade = (tempoDaContaEmAnos > 5) ? (decimal)5 / 100 : (decimal)tempoDaContaEmAnos / 100;

            if (statusContaCliente == 1)
            {
                precoAposDesconto = precoProduto;
            }
            else if (statusContaCliente == 2)
            {
                precoAposDesconto = (precoProduto - (0.1M * precoProduto)) - descontPorFidelidade * (precoProduto - (0.1M * precoProduto));
            }
            else if (statusContaCliente == 3)
            {
                precoAposDesconto = (0.7M * precoProduto) - descontPorFidelidade * (0.7M * precoProduto);
            }
            else if (statusContaCliente == 4)
            {
                precoAposDesconto = (precoProduto - (0.5M * precoProduto)) - descontPorFidelidade * (precoProduto - (0.5M * precoProduto));
            }

            return precoAposDesconto;
        }
    }
}