using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao;

        public void Registrar (Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.GetBonificacao();
        }

        //public void Registrar(Diretor diretor)
        //{
        //    this.totalBonificacao += diretor.GetBonificacao();
        //}
        // Agora que o diretor herda a classe funcionário, não precisa de um método especifico para o mesmo

        public double GetBonificacao()
        {
            return this.totalBonificacao;
        }
    }
}
