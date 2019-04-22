using System;
using System.Collections.Generic;

namespace UsingDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string> { "Thamirys", "Charlin", "Diana" };
            WriteLinesToFileNew(lst);
            Console.WriteLine("Arquivo gerado");
        }

        static void WriteLinesToFile(IEnumerable<string> lines)
        {
            using (var file = new System.IO.StreamWriter("WriteLines2.txt"))
            {
                foreach (string line in lines)
                {                   
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            } 
        }

        static void WriteLinesToFileNew(IEnumerable<string> lines)
        {
            using var file = new System.IO.StreamWriter("WriteLines2.txt");
            foreach (string line in lines)
            {
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
            }
        }
    }
}
