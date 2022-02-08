using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class Pessoa
    {
        // Field
        private DateTime _dataNascimento;

        // Properties
        public string Nome { get; private set; }
        public string Genero { get; private set; }
        public string Email { get; private set; }

        public DateTime DataNascimento
        {
            get => _dataNascimento;
            private set => _dataNascimento = value;
        }

        public Pessoa() { }

        public Pessoa(string nome, DateTime dataNascimento, string genero, string email)
        {
            Nome = nome;
            _dataNascimento = dataNascimento;
            Genero = genero;
            Email = email;
        }

        public void IndetificarPessoa()
        {
            Console.WriteLine($"{Nome} - {DataNascimento} - {Genero} - {Email}");
        }

    }
}
