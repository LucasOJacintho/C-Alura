using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoLucas = new ContaCorrente();

            contaDoLucas.titular = "Lucas Oliveira";
            contaDoLucas.agencia = 863;
            contaDoLucas.numero = 863452;
            contaDoLucas.saldo = 100;

            Console.WriteLine("Titular: " + contaDoLucas.titular);
            Console.WriteLine("Agência: " + contaDoLucas.agencia);
            Console.WriteLine("Número: " + contaDoLucas.numero);
            Console.WriteLine("Saldo: " + contaDoLucas.saldo);

            Console.ReadLine();
        }
    }
}
