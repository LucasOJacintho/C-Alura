using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13._1___ExercícioFOREncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Exercício laços aninhados e break");
            /*
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(j+1);
                }
                Console.WriteLine();
            }
            */

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j > i)
                    {
                        break;
                    }
                    Console.Write(j + 1);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Para encerrar a aplicação, pressione qualquer tecla . . .");
            Console.ReadLine();
        }
    }
}
