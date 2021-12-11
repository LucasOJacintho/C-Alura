using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idade = 16;
            bool acompanhante = true;
            
            /*
             * bool acompanhante = idade >= 14;
             * é possível realizar operações lógicas na atribuição de valores booleanos  
            */


            if (idade >= 18 || acompanhante == true) // execução com ou = || execução com e = &&
            {
                Console.WriteLine("Entrada liberada!");
            }
            else
            {
                Console.WriteLine("Você não pode entrar");
            }

            Console.WriteLine("Pressione qualquer tecla para encerrar a execução ...");

            Console.ReadLine();

        }
    }
}
