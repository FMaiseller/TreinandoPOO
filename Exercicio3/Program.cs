namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Número inválido. Por favor, digite um número válido.");
                return;
            }
            Console.Write("Digite o segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Número inválido. Por favor, digite um número válido.");
                return;
            }
            Console.Write("Escolha uma operação matemática (Digite o numero):");
            Console.WriteLine("\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");
            if (!int.TryParse(Console.ReadLine(), out int operacao) || operacao < 1 || operacao > 4)
            {
                Console.WriteLine("Operação inválida. Por favor, escolha uma operação válida (1, 2, 3 ou 4).");
                return;
            }
            switch (operacao)
            {
                case 1:
                    Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine(num2 == 0 ? "Divisão por zero não é permitida." : $"Resultado: {num1} / {num2} = {num1 / num2}");
                    break;
            }
        }
    }
}
