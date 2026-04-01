using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Aluno
    {
        String Nome;
        String Matricula;
        String Curso;
        double MediaNotas;

        public Aluno(String nome, String matricula, String curso, double mediaNotas)
        {
            Nome = nome;
            Matricula = matricula;
            Curso = curso;
            MediaNotas = mediaNotas;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"Média das Notas: {MediaNotas}");
        }
        public void VerificarAprovacao()
        {
            if (MediaNotas >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
