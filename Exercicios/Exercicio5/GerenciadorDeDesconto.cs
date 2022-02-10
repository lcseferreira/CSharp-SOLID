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
        private readonly ICalculaDescontoStatusContaFactory descontoStatusConta;

        public GerenciadorDeDesconto(ICalculaDescontoFidelidade _descontoFidelidade, ICalculaDescontoStatusContaFactory _descontoStatusConta)
        {
            descontoFidelidade = _descontoFidelidade;
            descontoStatusConta = _descontoStatusConta;
        }

        public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDaContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            precoAposDesconto = descontoStatusConta.GetCalculoDescontoStatusConta(statusContaCliente).AplicarDescontoStatusConta(precoProduto);

            precoAposDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoProduto, tempoDaContaEmAnos);

            return precoAposDesconto;
        }
    }
}