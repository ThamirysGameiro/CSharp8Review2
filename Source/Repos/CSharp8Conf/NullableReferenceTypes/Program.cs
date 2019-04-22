using System;
//#nullable enable
namespace NullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var nullable = new NullableReferenceTypes("Thamirys", "Gameiro", "Cavalcante");

            Console.WriteLine($"O seu nome tem {nullable.TamanhoDoNome()} caracteres");
        }
    }

    class NullableReferenceTypes
    {
        public string Nome { get; set; }
        public string? NomeDoMeio { get; set; }
        public string UltimoNome { get; set; }

        public int TamanhoDoNome()
        {
            return string.IsNullOrEmpty(NomeDoMeio) ? Nome.Length + UltimoNome.Length : Nome.Length + NomeDoMeio.Length + UltimoNome.Length;
        }

        public NullableReferenceTypes(string nome, string nomeDoMeio, string ultimoNome)
        {
            Nome = nome;
            //NomeDoMeio = null;
            UltimoNome = "Cavalcante";
        }
    }
}
