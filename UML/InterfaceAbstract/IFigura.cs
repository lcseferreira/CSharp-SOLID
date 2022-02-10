using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.InterfaceAbstract
{
    // Todos os membros de uma interface são públicos
    internal interface IFigura
    {
        // Property
        string Nome { get; set; }

        // Métodos
        void Desenhar();
        void Identificar();

        // A partir da versão 8.0 do C#, interfaces podem conter implementação padrão (default members)
        void Duplicar()
        {
            Console.WriteLine("Duplicando Figura");
        }
    }
}
