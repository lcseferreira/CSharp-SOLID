using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.InterfaceAbstract
{
    // Implementando a interface
    internal class CirculoInt : IFigura
    {
        // Propriedade obrigatória
        public string Nome { get; set; }

        // Métodos obrigatórios (sem implementação na interface, C# 8.0)
        public void Desenhar()
        {
            Console.WriteLine("Desenhando círculo");
        }

        public void Identificar()
        {
            Console.WriteLine("Círculo");
        }
    }
}
