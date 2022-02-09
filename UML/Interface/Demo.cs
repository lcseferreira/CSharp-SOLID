using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.Interface
{
    // A classe é obrigada a implementar tudo da interface
    internal class Demo : IControle, ITeste
    {
        public void Desenhar()
        {
            throw new NotImplementedException();
        }

        public void Testar()
        {
            throw new NotImplementedException();
        }
    }
}
