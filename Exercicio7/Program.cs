using static System.Net.Mime.MediaTypeNames;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta1 = new ContaBancaria("Felipe");

            conta1.Depositar(1000);
            conta1.ExibirSaldo();
            conta1.Sacar(200);
            conta1.ExibirSaldo();
            conta1.Sacar(900);
        }
    }
}

