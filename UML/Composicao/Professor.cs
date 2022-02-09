namespace UML.Composicao
{
    public class Professor : IDisposable
    {
        public string Nome { get; set; }
        public string Materia { get; set; }

        public void Dispose()
        {
        }
    }
}