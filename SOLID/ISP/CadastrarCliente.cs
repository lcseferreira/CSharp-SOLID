using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    internal class CadastrarCliente : IPersistencia, IMensagemEmail
    {
        public void EnviarEamil()
        {
            Console.WriteLine("Enviando email...");
        }

        public void SalvarDataBase()
        {
            Console.WriteLine("Salvando dados...");
        }

        public void ValidarDados()
        {
            Console.WriteLine("Validando dados...");
        }
    }
}
