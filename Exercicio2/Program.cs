namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome completo: ");
            string nome = Console.ReadLine();

            char[] letras = nome.ToCharArray();

            for (int i = 0; i < letras.Length; i++)
            {
                if ((letras[i] >= 'A' && letras[i] <= 'Z') ||
                (letras[i] >= 'a' && letras[i] <= 'z'))
                {
                    letras[i] = (char)(letras[i] + 2);
                }
            }
            string resultado = new string(letras);

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}

