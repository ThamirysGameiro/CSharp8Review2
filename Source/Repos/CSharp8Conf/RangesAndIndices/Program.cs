using System;


namespace RangesAndIndices
{
    class Program
    {
        static void Main(string[] args)
        {
            var ranges = new RangesAndIndices();

            //Console.WriteLine($"Retorna a posição 5 do array: {ranges.RetornaPosicao(5)}");
            Console.WriteLine($"Retorna a posição 2 do array, de tras para frente: {ranges.RetornaPosicaoInvertida(0)}");
            //Console.WriteLine($"Retorna trecho do array: {string.Join('-', ranges.RetornaTrecho(3, 8))}");
            Console.WriteLine($"Retorna trecho final invertido do array: {string.Join('-', ranges.RetornaTrechoFinalInvertido(3, 0))}");

        }
    }

    class RangesAndIndices
    {
        int[] MeuArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int RetornaPosicao(int i)
        {
            return MeuArray[i];
        }

        public int RetornaPosicaoInvertida(int i)
        {
            return MeuArray[^i];
        }

        public int[] RetornaTrecho(int inicio, int final)
        {
            // final == menor que
            return MeuArray[inicio..final];
        }

        public int[] RetornaTrechoFinalInvertido(int inicio, int final)
        {
            return MeuArray[inicio..^final];
        }
    }
}
 