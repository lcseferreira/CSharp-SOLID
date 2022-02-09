namespace UML.Composicao
{
    internal class Departamento : IDisposable
    {
        private string _nome;
        private Escola escola;

        // Relacionamento entre classes: Agregação => um departamento pode ter um ou mais professores
        public IList<Professor> professores { get; set; }

        // Internal porque nosso departamento só existe dentro do contexto da Escola
        internal Departamento(Escola escola, string nome)
        {
            this.escola = escola;
            this._nome = nome;  
        }

        public void Dispose()
        {

        }
    }
}