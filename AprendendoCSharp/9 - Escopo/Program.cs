using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando Projeto 9 - Escopo");

            int idade = 18;
            bool acompanhado = false;
            string mensagemAdicional;

            if (acompanhado == true)
                mensagemAdicional = "Você está acompanhado";
            else
                mensagemAdicional = "Você não está acompanhado";

            // Quando existe apenas uma linha de instrução não precisa de chaves
         
            Console.WriteLine(mensagemAdicional);

            if (idade >= 18 || acompanhado == true)
                Console.WriteLine("Você pode entrar");
            else
                Console.WriteLine("Você não pode entrar");


            Console.WriteLine("Pressione qualquer tecla para o encerramento do programa...");

            Console.ReadLine();

        }
    }
}
