using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string cpf, double salario)
        {
            Cpf = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public abstract double GetBonificacao();
        public abstract void AumentarSalario();
        public abstract double GetPremioSemestral();
        public static int TotalDeFuncionarios { get;  private set; }         
    }
}
// Virtaul é uma palavra reservada que permite reescrever esse metodo em classes filhas
//static é uma palavra reservada usada para definir quando um campo/propriedade pertence a classe e não ao objeto