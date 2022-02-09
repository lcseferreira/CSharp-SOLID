using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.Interface
{
    // Quando a classe for herdar de uma classe base e uma interface, a classe base sempre vem primeiro
    internal class GravarJSON : ArquivoBase, IGravar
    {
        public void GravarArquivo()
        {
            Console.WriteLine("Gravando arquivo em JSON...."); ;
        }

        public override void Nome()
        {
            Console.WriteLine("Definir nome em GravarJSON");
        }
    }
}
