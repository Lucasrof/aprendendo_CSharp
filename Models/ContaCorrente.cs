using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aprendendo_CSharp.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int NumeroConta, decimal saldoInicial)
        {
            numeroConta = NumeroConta;
            saldo = saldoInicial;
        }



        public int numeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!!");
            }
            else
            {
                Console.WriteLine("Não possui saldo suficiente para o saque");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponível é: " + saldo);
        }
    }
}