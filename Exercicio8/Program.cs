namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario("Maria", "Funcionario de TI", 5000);
            Gerente gerente1 = new Gerente("Felipe", "Gerente de TI", 5000);
            
            Console.WriteLine($"Salario do Funcionario {funcionario1.calcularSalario()}");
            Console.WriteLine($"Salario do Gerente {gerente1.calcularSalario()}");
        }
    }
}

