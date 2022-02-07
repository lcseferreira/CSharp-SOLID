namespace SOLID.POO
{
    public class Exemplo
    {
        public string Nome { get; set; }

        public Exemplo(string nome)
        {
            Nome = nome;

            // Passa a instância como um parâmetro
            Teste teste = new Teste(this);

            Console.WriteLine($"Exemplo: {teste.Nome}");

        }
    }

    public class Teste
    {
        public string Nome { get; set; }

        public Teste(Exemplo exemplo)
        {
            this.Nome = exemplo.Nome;

            Console.WriteLine($"Teste: {this.Nome}");
        }
    }
}
