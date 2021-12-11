using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13._3___DesafioFatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto - Desafio Fatorial");

            int resultado = 1;
            int fatorial = 6;

            Console.Write("O fatorial de " + fatorial + "! é = ");

            for (int i = 1; i <= fatorial; i++)
            {
                Console.Write(i);
                if (i < fatorial)
                    Console.Write(" x ");
                resultado *= i;
            }
            Console.WriteLine(" = "+ resultado);

            Console.WriteLine("Pressione qualquer tecla para encerrar o projeto");

            Console.ReadLine();
        }
    }
}
