using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 - Condicionais");

            int idade = 21;
            bool acompanhado = false;

            if (idade >= 18)
            {
                Console.WriteLine("Você possui mais que 18 anos de idade, portando pode entrar!");
            }
            else if (idade < 18 && acompanhado == true)
            {
                Console.WriteLine(" Você tem " + idade + " anos, porém por você estar acompanhado pode entrar.");
            }
            else
            {
                Console.WriteLine("Você não possui idade suficiente para entrar, daqui há " + (18 - idade) + " anos você poderá entrar.");
            }

            Console.WriteLine("Aperte qualquer tecla para encerrar a aplicação . . .");

            Console.ReadLine();

            //Crtl + k,d organiza o documento ou no menu, editar > avançado > formatar documento

        }
    }
}
