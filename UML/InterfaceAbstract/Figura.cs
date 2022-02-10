using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.InterfaceAbstract
{
    abstract class Figura
    {
        // Property
        protected string Nome { get; set; }

        // Constructor
        public Figura(string nome)
        {
            Nome = nome;
        }

        // Métodos abstratos são obrigatórios para quem implementa
        public abstract void Desenhar();

        public abstract void Identificar();

        // Método relativo para todas as figuras
        protected void Duplicar()
        {
            Console.WriteLine("Duplicando a figura");
        }
    }
}
