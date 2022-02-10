using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal class RecuperarSenha
    {
        // Módulos de alto nível (classes que dependem de outras classes) não devem depender de módulos de baixo nível. Ambos devem depender de uma abstração
        // Injeção de dependência
        private readonly IDataBaseConnection conexaoBanco;

        public RecuperarSenha(IDataBaseConnection _conexao)
        {
            conexaoBanco = _conexao;
        }
    }
}
