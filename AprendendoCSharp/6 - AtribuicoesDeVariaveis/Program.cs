using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___AtribuicoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ecução do projeto 6 - Atribuições de Variáveis");

            int idade = 29;
            int idadeLucas = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeLucas);

            Console.WriteLine("Pressione Enter para encerrar a execução do programa . . . ");

            Console.ReadLine();
        }
    }
}
