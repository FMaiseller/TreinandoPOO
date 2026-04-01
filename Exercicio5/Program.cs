
namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateOnly hoje = DateOnly.FromDateTime(DateTime.Now);
            DateOnly dataFormatura = new DateOnly(2026, 12, 15);

            Console.Write("Digite a data atual (dd/MM/yyyy): ");
            if (!DateOnly.TryParse(Console.ReadLine(), out DateOnly dataAtual))
            {
                Console.WriteLine("Data inválida.");
                return;
            }


            if (dataAtual > hoje)
            {
                Console.WriteLine("Erro: A data informada não pode ser no futuro!");
                return;
            }


            if (dataAtual > dataFormatura)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
                return;
            }

            int anos = dataFormatura.Year - dataAtual.Year;
            int meses = dataFormatura.Month - dataAtual.Month;
            int dias = dataFormatura.Day - dataAtual.Day;

            if (dias < 0)
            {
                meses--;
                var ultimoMes = dataFormatura.AddMonths(-1);
                dias += DateTime.DaysInMonth(ultimoMes.Year, ultimoMes.Month);
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura!");

            if (anos == 0 && meses < 6)
            {
                Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
            }
        }
    }
}
