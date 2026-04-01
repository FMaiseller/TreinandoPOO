using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    internal class MarkdownFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("## Lista de Contatos");

            foreach (var contato in contatos)
            {
                Console.WriteLine($"- **Nome:** {contato.Nome}");
                Console.WriteLine($"- 📞 Telefone: {contato.Telefone}");
                Console.WriteLine($"- 📧 Email: {contato.Email}");
                Console.WriteLine();
            }
        }
    }
}