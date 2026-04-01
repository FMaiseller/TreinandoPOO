namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 51);

            for (int tentativas = 5; tentativas > 0; tentativas--)
            {    
                Console.WriteLine("Digite um numero de 1 a 50");
                if (!int.TryParse(Console.ReadLine(), out int numeroDigitado) || numeroDigitado < 1 || numeroDigitado > 50)
                { 
                    Console.Clear();
                    Console.WriteLine("Número inválido. Por favor, digite um número entre 1 e 50.");
                    tentativas++;
                    continue;
                }

                if (numeroAleatorio != numeroDigitado)
                {
                    Console.WriteLine($"Você Errou! \nNumero de tentativas restantes {tentativas - 1}");
                    Console.WriteLine($"Aperte qualquer tecla para tentar novamente!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (numeroAleatorio == numeroDigitado)
                {
                    Console.WriteLine("Parabéns! Você adivinhou o número!");
                    break;
                }
            }
                Console.WriteLine($"O número correto era: {numeroAleatorio}");
                Console.WriteLine("Fim de Jogo!");
        }
    }
}
