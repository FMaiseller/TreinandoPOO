using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class Gerente : Funcionario
    {   
        
        public Gerente(String nome, String cargo, double salarioBase) : base(nome, cargo, salarioBase)
        {
            
        }
        public override double calcularSalario()
        {
            return SalarioBase * 1.20; 
        }

    }
}
