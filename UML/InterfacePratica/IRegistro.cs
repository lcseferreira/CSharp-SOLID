using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.InterfacePratica
{
    // Interface não define implementação
    internal interface IRegistro
    {
        // Contrato da interface
        void RegistraInfo(string mensagem);
    }
}
