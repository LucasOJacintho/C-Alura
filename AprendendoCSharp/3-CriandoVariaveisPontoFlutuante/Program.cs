using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 3 - Criando Variaveis Ponto Flututante");

            double salario = 1200.70;

            Console.WriteLine("O seu salário atual é de: R$" + salario);

            salario += 537.30;

            Console.WriteLine("Com o aumento seu novo salário será de R$" + salario);

            Console.WriteLine(salario.GetType());

            // Quando é realizado alguma operação onde o número resulta em um inteiro, ou seja X,000... o valor apresentado será sem vírgula ou ponto
            /* Mas não será por isso que o elemento deixa de ser Double, a função "Variável.GetType()" pode ser utilizada para verificar esse detalhe */

            Console.WriteLine("A execução acabou, tecle enter para sair . . .");
            Console.ReadLine();
        }
    }
}
