using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio_ClassesDeOperacoes.OpBasicas;

namespace Desafio_ClassesDeOperacoes
{
    public class Operacoes
    {
        public Soma Soma { get; set; }
        public Subtracao Subtracao { get; set; }
        public Multi Multi { get; set; }
        public Divisao Divisao { get; set; }

        public Operacoes()
        {
            this.Soma = new Soma();
            this.Subtracao = new Subtracao();
            this.Multi = new Multi();
            this.Divisao = new Divisao();
        }
    }
}
