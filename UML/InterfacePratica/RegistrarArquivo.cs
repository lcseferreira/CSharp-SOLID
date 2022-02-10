using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.InterfacePratica
{
    internal class RegistrarArquivo : IRegistro
    {
        // Caminho onde será gravado o log
        private readonly string _caminhoNomeArquivo;
        public RegistrarArquivo(string path)
        {
            _caminhoNomeArquivo = path;
        }

        public void RegistraInfo(string mensagem)
        {
            Log(mensagem);
        }

        private void Log(string mensagem)
        {
            using (var streamWriter = new StreamWriter(_caminhoNomeArquivo, true))
            {
                streamWriter.WriteLine(mensagem);
            }
        }
    }
}
