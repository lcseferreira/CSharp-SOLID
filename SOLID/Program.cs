using SOLID.POO;

namespace SOLID;

class Program
{
    static void Main(string[] args)
    {
        // Instânciando uma pessoa
        Pessoa pessoa1 = new Pessoa(0, "Lucas", 24, "Masculino", "Rua Gaspero Fiamoncine");

        // Acessando uma propriedade da classe
        // pessoa1.Nome = "Lucas";
        pessoa1.Idade = 24;
        pessoa1.Endereco = "Rua João Gomes Frossard";

        // Instânciando uma pessoa com construtor
        Pessoa pessoa2 = new Pessoa(1, "Eduardo", 48, "Masculino", "Rua Gasepero Fiamoncine");

        pessoa1.Identificar();
        pessoa2.Identificar();

        Console.WriteLine();

        Console.WriteLine(pessoa1);
        Console.WriteLine(pessoa2);

        /*** Exemplo THIS ***/
        Exemplo exemplo = new Exemplo("This");

        Console.WriteLine();

        /*** Exemplo sobrecarga de métodos ***/

        Console.WriteLine(SobrecargaMetodos.Somar(10, 20));
        Console.WriteLine(SobrecargaMetodos.Somar(10.0, 20.0));
        Console.WriteLine(SobrecargaMetodos.Somar(10, 20, 30, 40, 50, 60, 70, 80, 90, 100));

        Console.WriteLine(SobrecargaMetodos.SomarOpcional(numero1: 10, numero2: 20));
        Console.WriteLine(SobrecargaMetodos.SomarOpcional(numero1: 10, numero2: 20, opcional: 30));
    }
}