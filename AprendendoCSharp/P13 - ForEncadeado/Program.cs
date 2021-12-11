using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13___ForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13 - For Encadeado");

            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("*");
               Console.WriteLine();
            }

            Console.WriteLine("Pressione qualquer tecla para encerrar");

            Console.ReadLine();
        }
    }
}
