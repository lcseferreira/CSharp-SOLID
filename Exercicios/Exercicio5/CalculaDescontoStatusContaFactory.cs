using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicio5
{
    internal class CalculaDescontoStatusContaFactory : ICalculaDescontoStatusContaFactory
    {
        public ICalculaDescontoStatusConta GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente)
        {
            ICalculaDescontoStatusConta calcular;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    calcular = new ClienteNaoRegistrado();
                    break;

                case StatusContaCliente.ClienteComum:
                    calcular = new ClienteComum();
                    break;

                case StatusContaCliente.ClienteEspecial:
                    calcular = new ClienteEspecial();
                    break;

                case StatusContaCliente.ClienteVIP:
                    calcular = new ClienteVIP();
                    break;

                default:
                    throw new NotImplementedException();
            }

            return calcular;
        }
    }
}
