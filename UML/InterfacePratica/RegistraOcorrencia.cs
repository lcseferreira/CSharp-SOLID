using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.InterfacePratica
{
    internal class RegistraOcorrencia
    {
        private readonly IRegistro _registro;

        // Injeção de dependência da interface
        public RegistraOcorrencia(IRegistro registro)
        {
            _registro = registro;
        }

        public void Registrar(string mensagem)
        {
            _registro.RegistraInfo($"{mensagem} : {DateTime.Now}");
        }
    }
}
