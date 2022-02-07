using SOLID.POO;

namespace SOLID;

class Program
{
    static void Main(string[] args)
    {
        // Instânciando uma pessoa
        Pessoa pessoa1 = new Pessoa();

        // Acessando uma propriedade da classe
        pessoa1.nome = "Lucas";
        pessoa1.idade = 24;
        pessoa1.genero = "Masculino";

        // Instânciando uma pessoa com construtor
        Pessoa pessoa2 = new Pessoa("Eduardo", 48, "Masculino");

        pessoa1.Identificar();
        pessoa2.Identificar();
    }
}