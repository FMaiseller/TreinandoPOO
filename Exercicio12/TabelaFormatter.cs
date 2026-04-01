using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    internal class TabelaFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("| Nome | Telefone | Email |");
            Console.WriteLine("----------------------------------------");

            foreach (var contato in contatos)
            {
                Console.WriteLine($"| {contato.Nome} | {contato.Telefone} | {contato.Email} |");
            }

            Console.WriteLine("----------------------------------------");
        }
    }
}
