using System;
using System.ComponentModel;

namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = -1;
            string caminhoArquivo = "estoque.txt";
            string[] produtos;


            if (!File.Exists(caminhoArquivo))
            {
                File.Create(caminhoArquivo).Close();
            }

            do
            {
                Console.Clear();
                Console.WriteLine("---Controle de Estoque---");
                Console.WriteLine("\n1- Inserir Produto \n2-Listar Produtos \n3-Sair");
                if (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 3)
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida (1, 2 ou 3).");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                switch (opcao)
                {
                    case 1:

                        Console.Clear();

                        string[] linhas = File.ReadAllLines(caminhoArquivo);
                        if (linhas.Length >= 5)
                        {
                            Console.WriteLine("Limite de produtos atingido!");
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }

                        Console.Write("Digite o nome do produto: ");
                        string nome = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(nome))
                        {
                            Console.WriteLine("Nome inválido.");
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }

                        Console.Write("Digite a quantidade: ");
                        if (!int.TryParse(Console.ReadLine(), out int quantidade))
                        {
                            Console.WriteLine("Quantidade inválida.");
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }

                        Console.Write("Digite o preço: ");
                        if (!double.TryParse(Console.ReadLine(), out double preco))
                        {
                            Console.WriteLine("Preço inválido.");
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }

                        using (StreamWriter sw = File.AppendText(caminhoArquivo))
                        {
                            sw.WriteLine($"{nome},{quantidade},{preco}");
                        }

                        Console.WriteLine("O produto foi salvo!");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 2:

                        Console.Clear();

                        try
                        {
                            produtos = File.ReadAllLines(caminhoArquivo);
                        }
                        catch
                        {
                            Console.WriteLine("Erro ao acessar o arquivo.");
                            Console.ReadKey();
                            break;
                        }

                        if (produtos.Length == 0)
                        {
                            Console.WriteLine("Nenhum produto cadastrado.");
                        }
                        else
                        {
                            foreach (var linha in produtos)
                            {
                                try
                                {
                                    string[] dados = linha.Split(',');

                                    if (dados.Length != 3)
                                    {
                                        Console.WriteLine($"Linha com formato inválido.");
                                        continue;
                                    }
                                    Console.WriteLine(
                                        $"Produto: {dados[0]} | Quantidade: {dados[1]} | Preço: R$ {dados[2]}"
                                    );
                                }
                                catch
                                {
                                    Console.WriteLine("Erro ao ler um produto.");
                                }
                            }
                        }

                        Console.WriteLine("\nPressione qualquer tecla...");
                        Console.ReadKey();
                        break;
                }

            } while (opcao != 3);
        }
    }
}

