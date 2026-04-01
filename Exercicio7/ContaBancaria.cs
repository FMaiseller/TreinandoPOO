using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class ContaBancaria
    {
        public String Titular;
        private decimal Saldo;

        public ContaBancaria(String titular)
        {
            Titular = titular;
            Saldo = 0.0m;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser positivo!");
            }
        }
        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
        }
    }
}
