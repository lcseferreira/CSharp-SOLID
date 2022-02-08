using SOLID.POO;
using SOLID.POO.Casting;
using SOLID.POO.Heranca;

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

        // Usando argumentos nomeados
        Console.WriteLine(SobrecargaMetodos.SomarOpcional(numero1: 10, numero2: 20));
        Console.WriteLine(SobrecargaMetodos.SomarOpcional(numero1: 10, numero2: 20, opcional: 30));

        Console.WriteLine();

        // Usando método de extensão
        var texto = "teste método extensão";

        Console.WriteLine(texto.CapsLockPrimeiraLetra());

        Console.WriteLine();

        /*** Herança ***/
        // A ContaPoupanca herda de Conta, por isso ela vai executar o construtor da classe pai primeiro
        ContaPoupanca contapp1 = new ContaPoupanca(1, 3500);

        Console.WriteLine(contapp1.GetSaldo());

        Console.WriteLine();

        /*** Casting ***/
        // UpCasting = conversão do mais específico (classe filha) para o mais abstrato (classe pai)
        Circulo c1 = new Circulo();
        Forma f1 = c1;  // Conversão implícita

        Console.WriteLine(f1 == c1);
        f1.Desenhar();


        // DownCasting = conversão do mais abstrato (classe pai) para o mais específico (classe filha)
        Circulo c2 = (Circulo)f1;   // Conversão explícita

        Console.WriteLine(f1 == c2);
        c2.Desenhar();

        // Usando o AS
        Forma f3 = new Forma();
        Circulo c3 = f3 as Circulo; // O AS retorna null se a conversão não for possível

        if (c3 != null)
        {
            c3.Desenhar();
        }
        else
        {
            Console.WriteLine("Não foi possível fazer a conversão.");
        }

        // Usando o IS
        Circulo c4 = new Circulo();

        // O IS retorna true ou false
        if (c4 is Forma)
        {
            Forma f4 = c4;
            f4.Desenhar();
        }
        else
        {
            Console.WriteLine("c4 não é uma forma.");
        }


    }
}