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
            decimal descontPorFidelidade = (tempoDaContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE) ?
                (decimal)Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100 : (decimal)tempoDaContaEmAnos / 100;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoAposDesconto = precoProduto;
                    break;

                case StatusContaCliente.ClienteComum:
                    precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_COMUM * precoProduto));
                    precoAposDesconto -= (descontPorFidelidade * precoAposDesconto);
                    break;

                case StatusContaCliente.ClienteEspecial:
                    precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_ESPECIAL * precoProduto));
                    precoAposDesconto -= (descontPorFidelidade * precoAposDesconto);
                    break;

                case StatusContaCliente.ClienteVIP:
                    precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_VIP * precoProduto));
                    precoAposDesconto -= (descontPorFidelidade * precoAposDesconto);
                    break;

                default:
                    throw new NotImplementedException();
            }

            return precoAposDesconto;
        }
    }
}