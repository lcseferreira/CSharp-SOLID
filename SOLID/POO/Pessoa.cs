namespace SOLID.POO;

public class Pessoa
{
    // FIELD = campo ou atributo
    private string _nome;

    // PROPERTY - propriedade (encapsulamento)
    public string Nome
    {
        get { return _nome; }
        private set => _nome = value;
    }

    // AUTOMATIC PROPERTY - propriedade automática
    public int Id { get; private set; }
    public string Endereco { get; set; }
    public int Idade { get; set; }
    public string Genero { get; private set; }

    // CONSTRUCTOR = construtor
    public Pessoa() { }

    // SOBRECARGA DE CONSTRUTOR
    public Pessoa(int id, string nome, int idade, string genero, string endereco)
    {
        DomainExceptionValidation.When(id < 0, "O ID não pode ser negativo.");
        DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "O nome é obrigatório.");
        DomainExceptionValidation.When(string.IsNullOrEmpty(endereco), "O endereco é obrigatório.");

        if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(genero) || string.IsNullOrEmpty(endereco))
        {
            throw new InvalidOperationException();
        }

        Id = id;
        Nome = nome;
        Idade = idade;
        Genero = genero;
        Endereco = endereco;
    }

    // METHOD = método
    public void Identificar()
    {
        Console.WriteLine($"Olá, sou o {Nome}, tenho {Idade} anos e sou do sexo {Genero}.");
    }

    public override string? ToString()
    {
        return $"ID: {Id}\n" +
            $"Nome: {Nome}\n" +
            $"Idade: {Idade}\n" +
            $"Gênero: {Genero}\n" +
            $"Endereço: {Endereco}\n";
    }
}

