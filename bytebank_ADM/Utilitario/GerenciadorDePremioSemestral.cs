using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDePremioSemestral
    {
        private double totalPremiacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalPremiacao += funcionario.GetPremioSemestral();
        }
        public double GetPremiacao()
        {
            return this.totalPremiacao;
        }
    }
}

