using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Cliente lucas = new Cliente();

            lucas.nome = "Lucas Oliveira";
            lucas.cpf = "123.456.789-00";
            lucas.profissao = "Desenvolvedor";
            */

            ContaCorrente conta = new ContaCorrente();


            //conta.titular = lucas;
            conta.titular = new Cliente();
            Console.WriteLine("Insira o nome do cliente:");
            conta.titular.nome = Console.ReadLine();
            Console.WriteLine("Insira a idade do cliente: ");
            conta.titular.idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o CPF do cliente:");
            conta.titular.cpf = Console.ReadLine();
            Console.WriteLine("Insira a profissão do cliente:");
            conta.titular.profissao = Console.ReadLine();
            
            Console.WriteLine();    

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;
            

            Console.WriteLine("Nome: " + conta.titular.nome);
            Console.WriteLine("CPF: " + conta.titular.cpf);
            Console.WriteLine("Profissão: " + conta.titular.profissao);
            Console.WriteLine("Saldo: R$" + conta.saldo);

            Console.ReadLine();
        }
    }
}
