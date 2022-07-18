using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_ClassesDeOperacoes.OpBasicas
{
    public class Multi
    {
        public double Calcular (double n1, double n2)
        {
            if (n1 == 0 || n2 == 0)
            {
                return 0;
            }
            else
            {
                return n1 * n2;
            }
        }
    }
}
