using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    internal class Contato
    {
        string Nome;
        string Telefone;
        string Email;

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
            if (!File.Exists(caminhoArquivo))
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                Pausar();
                Console.Clear();
                return;
            }
            try
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);

                if (linhas.Length == 0)
                {
                    Console.WriteLine("Nenhum contato cadastrado.");
                    Pausar();
                    Console.Clear();
                    return;
                }
                Console.Clear();
                Console.WriteLine("=== Contatos Cadastrados ===");
                foreach (string linha in linhas)
                {
                    string[] dadosContato = linha.Split(',');
                    if (dadosContato.Length == 3)
                    {
                        Console.WriteLine($"Nome: {dadosContato[0]}, Telefone: {dadosContato[1]}, Email: {dadosContato[2]}");
                    }
                    else
                    {
                        Console.WriteLine("Contato com formato inválido encontrado.");
                        continue;
                    }
                }
                Pausar();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao ler o arquivo de contatos: " + ex.Message);
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
