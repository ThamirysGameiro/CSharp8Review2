using System;

namespace StaticLocalFunction
{
    class Program
    {
        public static string Nome { get; set; }
        public static string Sobrenome { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine(NomeCompletoNovo());
        }

        private static string NomeCompleto()
        {
            Nome = "Thamirys";
            Sobrenome = "Gameiro";

            return JuntarNome();

            string JuntarNome() => $"{Nome} {Sobrenome}";
        }

        private static string NomeCompletoNovo()
        {
            return JuntarNome("Thamirys", "Gameiro");

            static string JuntarNome(string nome, string sobrenome) => $"{nome} {sobrenome}";
        }

    }
}
