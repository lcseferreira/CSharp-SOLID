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
        private readonly ICalculaDescontoStatusConta descontoPorStatusConta;

        public GerenciadorDeDesconto(ICalculaDescontoFidelidade _descontoFidelidade, ICalculaDescontoStatusConta _descontoPorStatusConta)
        {
            descontoFidelidade = _descontoFidelidade;
            descontoPorStatusConta = _descontoPorStatusConta;
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
                    descontoPorStatusConta.AplicarDescontoStatusConta(precoProduto, Constantes.DESCONTO_CLIENTE_COMUM);
                    descontoFidelidade.AplicarDescontoFidelidade(preco: precoProduto, tempoDeContaEmAnos: tempoDaContaEmAnos);
                    break;

                case StatusContaCliente.ClienteEspecial:
                    descontoPorStatusConta.AplicarDescontoStatusConta(precoProduto, Constantes.DESCONTO_CLIENTE_ESPECIAL);
                    descontoFidelidade.AplicarDescontoFidelidade(preco: precoProduto, tempoDeContaEmAnos: tempoDaContaEmAnos);
                    break;

                case StatusContaCliente.ClienteVIP:
                    descontoPorStatusConta.AplicarDescontoStatusConta(precoProduto, Constantes.DESCONTO_CLIENTE_VIP);
                    descontoFidelidade.AplicarDescontoFidelidade(preco: precoProduto, tempoDeContaEmAnos: tempoDaContaEmAnos);
                    break;

                default:
                    throw new NotImplementedException();
            }

            return precoAposDesconto;
        }
    }
}