using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            ContaCorrente contaDoLucas = new ContaCorrente();

            contaDoLucas.titular = "Lucas Oliveira";
            contaDoLucas.agencia = 863;
            contaDoLucas.numero = 863452;

            ContaCorrente contaDaNoemi = new ContaCorrente();

            contaDaNoemi.titular = "Noemi Oliveira";
            contaDaNoemi.agencia = 742;
            contaDaNoemi.numero = 877252;

            Console.WriteLine(contaDoLucas.titular);
            Console.WriteLine(contaDoLucas.agencia);
            Console.WriteLine(contaDoLucas.numero);
            Console.WriteLine(contaDoLucas.saldo);

            contaDoLucas.Sacar(50);

            Console.WriteLine("Saldo do " + contaDoLucas.titular + " - R$" + contaDoLucas.saldo);

            contaDoLucas.Depositar(500);

            Console.WriteLine("Saldo do " + contaDoLucas.titular + " - R$" + contaDoLucas.saldo);

            bool resultadoTransferencia = contaDoLucas.Transferir(200, contaDaNoemi);

            Console.WriteLine("Resultado da Transferência: " + resultadoTransferencia);

            Console.WriteLine("Saldo do " + contaDaNoemi.titular + " - R$" + contaDaNoemi.saldo);

            resultadoTransferencia = contaDaNoemi.Transferir(150, contaDoLucas);

            Console.WriteLine("Resultado da Transferência: " + resultadoTransferencia);

            Console.WriteLine("Saldo do " + contaDoLucas.titular + " - R$" + contaDoLucas.saldo);

            Console.ReadLine();
        }
    }
}
