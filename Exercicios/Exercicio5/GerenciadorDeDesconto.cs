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

        public GerenciadorDeDesconto(ICalculaDescontoFidelidade _descontoFidelidade, ICalculaDescontoStatusConta _descontoPorStatusConta)
        {
            descontoFidelidade = _descontoFidelidade;
        }

        public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDaContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoAposDesconto = new ClienteNaoRegistrado().AplicarDescontoStatusConta(precoProduto);
                    break;

                case StatusContaCliente.ClienteComum:
                    precoAposDesconto = new ClienteComum().AplicarDescontoStatusConta(precoProduto);
                    descontoFidelidade.AplicarDescontoFidelidade(preco: precoProduto, tempoDeContaEmAnos: tempoDaContaEmAnos);
                    break;

                case StatusContaCliente.ClienteEspecial:
                    precoAposDesconto = new ClienteEspecial().AplicarDescontoStatusConta(precoProduto);
                    descontoFidelidade.AplicarDescontoFidelidade(preco: precoProduto, tempoDeContaEmAnos: tempoDaContaEmAnos);
                    break;

                case StatusContaCliente.ClienteVIP:
                    precoAposDesconto = new ClienteVIP().AplicarDescontoStatusConta(precoProduto);
                    descontoFidelidade.AplicarDescontoFidelidade(preco: precoProduto, tempoDeContaEmAnos: tempoDaContaEmAnos);
                    break;

                default:
                    throw new NotImplementedException();
            }

            return precoAposDesconto;
        }
    }
}