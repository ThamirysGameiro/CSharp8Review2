using Modelo;
using System;

namespace PropertyPatterns
{    

   

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa() { Nome = "Sula" };

            //Console.WriteLine(MVPeias(p));
            Console.WriteLine(MVPeiasWhen(p));
        }

        private static string MVPeias(Pessoa pessoa) =>
            pessoa switch
        {
            { Nome: "Thamirys", Sobrenome: "Gameiro" } => "C#",
            { Nome: "Dani" } => "Banco de dados",
            { Nome: "Jaque" } => "Azure",
            { Nome: "Diana" } => "Azure",
            { Nome: "Sula" } => "Banco de dados",
            { Nome: "Viviane" } => "BI",
            { Nome: "Letticia" } => "Xamarin",
            { Nome: "Charlin" } => "Xamarin",
            { Nome: "Leomaris" } => "Xamarin",
            { Nome: "Sorey" } => "Xamarin",
            { Nome: "Vivian" } => "IOT",
            { Nome: "Loiane" } => "Front",
            { Nome: "Sara" } => "Office",
            { Nome: "Karine" } => "BI",
            { Nome: "Fernanda" } => "Front",
            _ => "Não é MVPeia"
        };

        private static string MVPeiasWhen(object obj) =>
           obj switch
           {
               Pessoa p when p.Nome == "Thamirys" => "C#",
               Pessoa p when p.Nome == "Dani" || p.Nome == "Sula" => "Banco de dados",
               Pessoa p when p.Nome ==  "Jaque" || p.Nome == "Diana" => "Azure",
               Pessoa p when p.Nome == "Letticia" || p.Nome == "Charlin" || p.Nome == "Leomaris" || p.Nome == "Sorey" => "Xamarin",
               Pessoa p when p.Nome == "Vivian" => "IOT",
               Pessoa p when p.Nome == "Loiane" || p.Nome == "Fernanda" => "Front",
               Pessoa p when p.Nome == "Sara" => "Office",
               Pessoa p when p.Nome == "Karine" => "BI",              
               _ => "Não é MVPeia"
           };
    }
}
