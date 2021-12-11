using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11___CalculaPoupanca2
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Executando o projeto 11 - Calculo de poupança 2");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes ++)
            {
                valorInvestido = valorInvestido * 1.0036;
                Console.WriteLine("O rendimento durante o período de " + contadorMes + " será de R$" + valorInvestido);
            }

            Console.WriteLine("Pressione qualquer tecla para encerrar a aplicação");

            Console.ReadLine();

        }
    }
}
