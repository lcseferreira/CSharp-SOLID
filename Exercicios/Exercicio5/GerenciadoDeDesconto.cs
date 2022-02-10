using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicio5
{
    internal class GerenciadorDeDesconto
    {
        public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDaContaEmAnos)
        {
            decimal precoAposDesconto = 0;
            decimal descontPorFidelidade = (tempoDaContaEmAnos > 5) ? (decimal)5 / 100 : (decimal)tempoDaContaEmAnos / 100;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoAposDesconto = precoProduto;
                    break;

                case StatusContaCliente.ClienteComum:
                    precoAposDesconto = (precoProduto - (0.1M * precoProduto)) - descontPorFidelidade * (precoProduto - (0.1M * precoProduto));
                    break;

                case StatusContaCliente.ClienteEspecial:
                    precoAposDesconto = (0.7M * precoProduto) - descontPorFidelidade * (0.7M * precoProduto);
                    break;

                case StatusContaCliente.ClienteVIP:
                    precoAposDesconto = (precoProduto - (0.5M * precoProduto)) - descontPorFidelidade * (precoProduto - (0.5M * precoProduto));
                    break;

                default:
                    throw new NotImplementedException();
            }

            return precoAposDesconto;
        }
    }
}