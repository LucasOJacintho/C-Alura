using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12___CalculaInvestimentoLongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 12 - Calculo de Investimento de Longo Prazo");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;
            int prazo = 5;

            for (int contadorAno = 1; contadorAno <= prazo; contadorAno++)
            {
                for (int mes=1; mes <= 12; mes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.001;
            }

            Console.WriteLine("O tempo que o valor ficou investido foi de " + 12*prazo + " meses!");

            Console.WriteLine("Ao término do investimento, você terá o valor de R$" + valorInvestido);

            Console.WriteLine("Pressione qualquer tecla para encerrar...");

            Console.ReadLine();
        }
    }
}
