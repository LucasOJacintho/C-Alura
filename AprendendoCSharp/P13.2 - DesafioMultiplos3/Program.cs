using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13._2___DesafioMultiplos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto - Desfaio Múltiplos de 3");

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Pressione qualquer tecla para encerrar...");

            Console.ReadLine();
        }
    }
}
