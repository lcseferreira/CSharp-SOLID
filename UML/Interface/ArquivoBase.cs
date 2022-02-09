using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.Interface
{
    internal class ArquivoBase
    {
        public virtual void Nome()
        {
            Console.WriteLine("Definir nome do arquivo.");
        }
    }
}
