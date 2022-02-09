using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.ClasseAbstrata
{
    // Herdando de uma classe abstrata
    internal class Quadrado : Forma
    {
        // Properties
        public double Lado { get; set; }

        // Implementando métodos da classe pai abstrata (OBRIGATÓRIO)
        public override void CalcularArea()
        {
            Area = Lado * Lado;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = 4 * Lado;
        }
    }
}
