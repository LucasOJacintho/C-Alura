using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoLucas = new ContaCorrente();

            contaDoLucas.titular = "Lucas Oliveira";
            contaDoLucas.agencia = 863;
            contaDoLucas.numero = 863452;

            Console.WriteLine(contaDoLucas.titular);
            Console.WriteLine(contaDoLucas.agencia);
            Console.WriteLine(contaDoLucas.numero);
            Console.WriteLine(contaDoLucas.saldo);

            if (contaDoLucas.saldo >= 100)
            {
                contaDoLucas.saldo -= 20;
            }




            Console.ReadLine();
        }
    }
}
