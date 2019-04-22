using System;

namespace Modelo
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }

    public class Programadora : Pessoa
    {
        public string Linguagem { get; set; }
    }

    public class DBA : Pessoa
    {
        public string Banco { get; set; }
        public bool Relacional { get; set; }
    }
}
