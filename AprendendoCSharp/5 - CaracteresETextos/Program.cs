using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            char primeiraLetra = 'd';
            // O Char deve receber ao valor com aspas simples
            // O Char é compreendido como um número - tamanho máximo 16 bits

            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;

            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + primeiraLetra); 

            //Conversão de acordo com a tabela ASCII

            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia";

            //String recebe textos -> escrever com aspas duplas

            titulo = titulo + " " + 2020;

            Console.WriteLine(titulo);

            string cursoProgramacao = @"- .NET
- Java
- Javascript"; 

            // O @ na frente da variável permite que a mesma possua várias linhas

            Console.WriteLine(cursoProgramacao);

            string saudacao = "Olá, meu nome é ";
            string nome = "Lucas";
            string continuacao = " e minha idade é ";
            int idade = 29;
            Console.WriteLine(saudacao + nome + continuacao + idade);

            Console.WriteLine("Aperte Enter para encerrar a aplicação. . .");

            Console.ReadLine();
        }
    }
}
