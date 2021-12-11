using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando Projeto 10 - Calcula Poupança");

            double valorInvestido = 1000;
            int meses = 1;

            while (meses <= 12)
            {
                valorInvestido = valorInvestido + (valorInvestido * 0.0036);
                Console.WriteLine("Após " + meses + " você terá R$ " + valorInvestido + " !");
                meses ++; // usar o ++ quando o incremedo deve ser de 1 em 1 , usar o += quando o incremento for de um outro valor diferente de 1
            }

            // 0.36% = 0.0036

            Console.WriteLine("Para encerrar a aplicação pressione qualquer tecla...");

            Console.ReadLine();
        }
    }
}
