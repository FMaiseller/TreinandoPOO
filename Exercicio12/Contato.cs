using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    internal class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }


        public static void AdicionarContato(string caminhoArquivo)
        {
            Console.Clear();
            Console.Write("Digite o nome do contato: ");
            string nome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Nome inválido.");
                Pausar();
                Console.Clear();
                return;
            }

            Console.Write("Digite o telefone do contato: ");
            string telefone = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(telefone))
            {
                Console.WriteLine("Telefone inválido.");
                Pausar();
                Console.Clear();
                return;
            }

            Console.Write("Digite o email do contato: ");
            string email = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Email inválido.");
                Pausar();
                Console.Clear();
                return;
            }

            Contato novoContato = new Contato(nome, telefone, email);
            try
            {
                using (StreamWriter sw = File.AppendText(caminhoArquivo))
                {
                    sw.WriteLine($"{novoContato.Nome},{novoContato.Telefone},{novoContato.Email}");
                }
            } catch (Exception)
            {
                Console.WriteLine("Erro ao salvar o contato ");
                Pausar();
                Console.Clear();
                return;
            }
            Console.WriteLine("Contato adicionado com sucesso!");
            Pausar();
            Console.Clear();
        }

        public static void ListarContatos(string caminhoArquivo)
        {
            Console.Clear();

            if (!File.Exists(caminhoArquivo))
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                Pausar();
                return;
            }

            try
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);

                if (linhas.Length == 0)
                {
                    Console.WriteLine("Nenhum contato cadastrado.");
                    Pausar();
                    return;
                }

                List<Contato> contatos = new List<Contato>();

                foreach (string linha in linhas)
                {
                    string[] dadosContato = linha.Split(',');

                    if (dadosContato.Length == 3)
                    {
                        contatos.Add(new Contato(dadosContato[0], dadosContato[1], dadosContato[2]));
                    }
                }

                Console.WriteLine("Escolha o formato de exibição:");
                Console.WriteLine("1 - Markdown");
                Console.WriteLine("2 - Tabela");
                Console.WriteLine("3 - Texto puro");
                if (!int.TryParse(Console.ReadLine(), out int escolha))
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida.");
                    Pausar();
                    Console.Clear();
                    return;
                }

                ContatoFormatter formatter;
                switch (escolha)
                {
                    case 1:
                        formatter = new MarkdownFormatter();
                        break;
                    case 2:
                        formatter = new TabelaFormatter();
                        break;
                    case 3:
                        formatter = new RawTextFormatter();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida.");
                        Pausar();
                        Console.Clear();
                        return;
                }

                Console.Clear();
                formatter.ExibirContatos(contatos); 

                Pausar();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.WriteLine("Erro, tente novamente");
                Pausar();
                Console.Clear();
            }
        }
        static void Pausar()
        {
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
