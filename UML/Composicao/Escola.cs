namespace UML.Composicao
{
    public class Escola : IDisposable
    {
        public string Nome { get; set; }
        private IList<Departamento> departamentos = new List<Departamento>();

        // A escola é responsável pela criação de departamentos
        public void AddDepartamento(string nome)
        {
            departamentos.Add(new Departamento(this, nome));
        }

        public void Dispose()
        {
            foreach (var departamento in departamentos) departamento.Dispose();
        }
    }
}
