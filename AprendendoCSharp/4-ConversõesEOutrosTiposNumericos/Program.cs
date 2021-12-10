using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversõesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4 - Conversões e Outros Tipos Númericos");

            double salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            // O nome dessa função de conversão é cast, com isso é óvio será perdido o valor flutuante

            Console.WriteLine(salarioEmInteiro);

            int idade;
            idade = 26;
            Console.WriteLine(idade);
            Console.WriteLine();

            // Não é possível adicionar números grandes com int - máximo de 32bits - pouco mais de 2 bilhões 2.000.000.000

            long idadeUniverso;
            idadeUniverso = 13000000000;
            Console.WriteLine("A idade do universo é de: " + idadeUniverso + " anos.");

            // long 64 bits

            short quantidadeProdutos = 150;
            Console.WriteLine();
            // short 16 bits

            float altura;
            altura = 1.86f;
            // float possui uma precisão menor que o double em relação ao número de casas decimais
            // para usar o float é necessário terminar o número com um f
            Console.WriteLine(altura);

            Console.WriteLine("Aperte Enter para encerrar a aplicação. . .");

            Console.ReadLine();
        }
    }
}
