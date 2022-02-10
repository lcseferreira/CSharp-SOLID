using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.InterfaceAbstract
{
    // Herdando a classe abstrata
    internal class QuadradoAbs : Figura
    {
        // Construtor obrigatório 
        public QuadradoAbs(string nome) : base(nome)
        {
        }

        // Métodos abstratos obrigatórios 
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando quadrado");
            Duplicar();
        }

        public override void Identificar()
        {
            Console.WriteLine("Quadrado");
        }
    }
}
