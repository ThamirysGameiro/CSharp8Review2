using Modelo;
using System;

namespace SwitchExpression
{
    class Program
    {
        enum Semana
        {
            Segunda = 2,
            Terca,
            Quarta,
            Quinta,
            Sexta,
            Sabado,
            Domingo
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(RetornaAcaoSwitchExpression(Semana.Sexta));

            Programadora dev = new Programadora
            {
                Linguagem = "C#",
                Nome = "Thamirys",
                Sobrenome = "Gameiro"
            };

            DBA dba = new DBA
            {
                Banco = "MongoDB",
                Nome = "Dani",
                Sobrenome = "Monteiro",
                Relacional = false
            };

            Pessoa p = new Pessoa { Nome = "Jaqueline", Sobrenome = "Ramons" };

            Console.WriteLine(MVPeiasConversao(dev));
            Console.WriteLine(MVPeiasConversao(dba));
            Console.WriteLine(MVPeiasConversao(p));

        }

        private static string RetornaAcaoSwitch(Semana semana)
        {
            string retorno;

            switch(semana)
            {
                case Semana.Segunda:
                    return "Semana começando ... animo!!!";

                case Semana.Terca:
                    return "Calma que já está quase na metade ...";

                case Semana.Quarta:
                    return "Chegamos a metade ... MVP Conf está perto !";

                case Semana.Quinta:
                    return "É amanhã !!!";

                case Semana.Sexta:
                    return "Começou !!! Ansiosa para assistir as palestras";

                case Semana.Sabado:
                    return "Segundo dia, vou aproveitar muito !!";

                case Semana.Domingo:
                    retorno = "Bora brincar com as coisas que aprendi :)";
                    break;
                default:
                    retorno = "Dia não identificado";
                    break;
            };

            return retorno;
        }
          

        private static string RetornaAcaoSwitchExpression(Semana semana) =>        
             semana switch
            {
                Semana.Segunda => "Semana começando ... animo!!!",
                Semana.Terca => "Calma que já está quase na metade ...",
                Semana.Quarta => "Chegamos a metade ... MVP Conf está perto !",
                Semana.Quinta => "É amanhã !!!",
                Semana.Sexta => "Começou !!! Ansiosa para assistir as palestras",
                Semana.Sabado => "Segundo dia, vou aproveitar muito !!",
                Semana.Domingo => "Bora brincar com as coisas que aprendi :)",
                _ => "Dia não identificado"
            };

        private static string RetornaAcaoSwitchExpressionVar(Semana semana)
        {
            var retorno = semana switch
            {
                Semana.Segunda => "Semana começando ... animo!!!",
                Semana.Terca => "Calma que já está quase na metade ...",
                Semana.Quarta => "Chegamos a metade ... MVP Conf está perto !",
                Semana.Quinta => "É amanhã !!!",
                Semana.Sexta => "Começou !!! Ansiosa para assistir as palestras",
                Semana.Sabado => "Segundo dia, vou aproveitar muito !!",
                Semana.Domingo => "Bora brincar com as coisas que aprendi :)",
                _ => "Dia não identificado"
            };

            return retorno;
        }

        private static string MVPeiasConversao(Pessoa p) =>
           (p) switch
        {
            Programadora prog => $"A {prog.Nome} é dev s2 e programa em {prog.Linguagem}",
            DBA dba => $"A {dba.Nome} é DBA, usa o banco {dba.Banco}, que {(dba.Relacional ? "é" : "não é")} relacional",
            _ => $"A {p.Nome} é de uma area diferente de Dev e DBA"
        };

        //private static string ConversaoGeral(object obj)
    }
}
