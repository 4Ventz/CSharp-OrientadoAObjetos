using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public virtual double GetBonificacao()
        {
            return Salario * 0.1;           
        }

        public virtual double GetPremioSemestral()
        {
            return Salario * 0.2;
        }
    }
}
// Virtaul é uma palavra reservada que permite reescrever esse metodo em classes filhas