using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade = 28;

            Console.WriteLine(idade);

            idade -= 10;

            Console.WriteLine("Sua idade é: " + idade + " anos 1!");

            Console.WriteLine("Pressione Enter para encerrar . . .");
            Console.ReadLine();
        }
    }
}
