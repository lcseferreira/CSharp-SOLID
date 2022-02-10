using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicio5
{
    internal class GerenciadorDeDesconto
    {
        // Aplicando DIP - Dependency Inversion Principle: dependa de abstrações e não de implementações
        private readonly ICalculaDescontoFidelidade descontoFidelidade;

        public GerenciadorDeDesconto(ICalculaDescontoFidelidade _descontoFidelidade)
        {
            descontoFidelidade = _descontoFidelidade;
        }

        public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDaContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoAposDesconto = precoProduto;
                    break;

                case StatusContaCliente.ClienteComum:
                    precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_COMUM * precoProduto));
                    descontoFidelidade.AplicarDescontoFidelidade(preco: precoProduto, tempoDeContaEmAnos: tempoDaContaEmAnos);
                    break;

                case StatusContaCliente.ClienteEspecial:
                    precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_ESPECIAL * precoProduto));
                    descontoFidelidade.AplicarDescontoFidelidade(preco: precoProduto, tempoDeContaEmAnos: tempoDaContaEmAnos);
                    break;

                case StatusContaCliente.ClienteVIP:
                    precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_VIP * precoProduto));
                    descontoFidelidade.AplicarDescontoFidelidade(preco: precoProduto, tempoDeContaEmAnos: tempoDaContaEmAnos);
                    break;

                default:
                    throw new NotImplementedException();
            }

            return precoAposDesconto;
        }
    }
}