using System;

namespace TuplePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MVPeiasTupla("Charlin", "Xamarin", false));
        }

        private static string MVPeiasTupla(string nome, string area, bool palestraConf) =>
            (nome, area, palestraConf) switch
        {
            (nome: "Thamirys", area: "C#", palestraConf: true) => "Brasil",
            { nome: "Dani", area: "Banco de dados", palestraConf: true } => "Brasil",
            { nome: "Jaque", area: "Azure", palestraConf: true } => "Brasil",
            { nome: "Diana", area: "Azure", palestraConf: false } => "Latam",
            { nome: "Sula", area: "Banco de dados", palestraConf: true } => "Brasil",
            { nome: "Viviane", area: "BI", palestraConf: false } => "Brasil",
            { nome: "Letticia", area: "Xamarin", palestraConf: true } => "Brasil",
            { nome: "Charlin", area: "Xamarin", palestraConf: false } => "Latam",
            { nome: "Leomaris", area: "Xamarin", palestraConf: false } => "Latam",
            { nome: "Sorey", area: "Xamarin", palestraConf: false } => "Latam",
            { nome: "Vivian", area: "IOT", palestraConf: true } => "Brasil",
            { nome: "Loiane", area: "Front", palestraConf: false } => "Brasil",
            { nome: "Sara", area: "Office", palestraConf: false } => "Brasil",
            { nome: "Karine", area: "BI", palestraConf: false } => "Brasil",
            { nome: "Fernanda", area: "Front", palestraConf: false } => "Brasil",
            _ => "Não é MVPeia"
        };
    }
}
