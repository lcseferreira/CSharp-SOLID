namespace SOLID.POO;

public class Pessoa
{
    // FIELD = campo ou atributo
    public string nome;
    public int idade;
    public string genero;

    // CONSTRUCTOR = construtor
    public Pessoa() { }

    // SOBRECARGA DE CONSTRUTOR
    public Pessoa(string nome, int idade, string genero)
    {
        this.nome = nome;
        this.idade = idade;
        this.genero = genero;
    }

    // METHOD = métodos
    public void Identificar()
    {
        Console.WriteLine($"Olá, sou o {nome}, tenho {idade} anos e sou do sexo {genero}.");
    }
}

