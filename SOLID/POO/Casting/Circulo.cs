using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.POO.Casting
{
    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando círculo...");
        }

        public void PintarCirculo()
        {
            Console.WriteLine("Pintando círculo...");
        }
    }
}
