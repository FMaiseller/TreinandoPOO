namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua data de nascimento(dd/mm/yyyy)");
            if (!DateOnly.TryParse(Console.ReadLine(), out DateOnly dataNascimento))
            {
                Console.WriteLine("Data de nascimento inválida. Por favor, digite uma data válida (formato: dd/MM/yyyy).");
                return;
            }
            DateOnly dataAtual = DateOnly.FromDateTime(DateTime.Now);
            
            var proximoAniversario = new DateOnly(dataAtual.Year, dataNascimento.Month, dataNascimento.Day);

            if (proximoAniversario < dataAtual)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }
            var diasFaltando = proximoAniversario.DayNumber - dataAtual.DayNumber;
            if (diasFaltando < 7)
            {
                Console.WriteLine($"Faltam apenas {diasFaltando} dias para o seu próximo aniversário! Que emocionante!");
            }
            else
            {
                Console.WriteLine($"Faltam {diasFaltando} dias para o seu próximo aniversário.");
            }
        }   
    }
}

