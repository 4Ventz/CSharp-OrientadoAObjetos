using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario //Herança, Classe Diretor Herda os elementos da classe Funcionário (nome, cpf, salário)
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Criando um Diretor.");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override double GetPremioSemestral()
        {
            throw new NotImplementedException();
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
//Override é uma palavra reservada utilizada para sinalizar ao compilador que o metodo pode ser reescrito.Lembrando que temos que utilizar a palavra reservada Virtual na classe mãe!
//Atalho: escrever "ctor" + Precionar 2x "tab" = Cria um construtor da classe atual.