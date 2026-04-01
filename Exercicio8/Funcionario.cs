using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class Funcionario
    {
        String Nome;
        String Cargo;
        internal double SalarioBase;

        public Funcionario(String nome, String cargo, double salarioBase)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioBase = salarioBase;
        }
            public virtual double calcularSalario()
        {
            return SalarioBase;
        }
    }
}
