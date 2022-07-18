using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor:Funcionario //Herança, Classe Diretor Herda os elementos da classe Funcionário (nome, cpf, salário)
    {
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }

        public override double GetPremioSemestral()
        {
            return Salario + base.GetPremioSemestral();
        }
    }
}
//Override é uma palavra reservada utilizada para sinalizar ao compilador que o metodo pode ser reescrito. 
//Lembrando que temos que utilizar a palavra reservada Virtual na classe mãe!