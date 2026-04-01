using System;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = -1;
            string caminhoArquivo = "contatos.txt";
            if (!File.Exists(caminhoArquivo))
            {
                File.Create(caminhoArquivo).Close();
            }

            do
            {
                Console.WriteLine("=== Gerenciador de Contatos ===");
                Console.WriteLine("1 - Adicionar novo contato");
                Console.WriteLine("2 - Listar contatos cadastrados");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                if (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida (1, 2 ou 3).");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                switch(opcao)
                {
                    case 1:
                        Contato.AdicionarContato(caminhoArquivo);
                        break;
                    case 2:
                        Contato.ListarContatos(caminhoArquivo);
                        break;
                    case 3:
                        Console.WriteLine("Encerrando programa...");
                        break;
                }
            } while (opcao != 3);
        }
    }
}
