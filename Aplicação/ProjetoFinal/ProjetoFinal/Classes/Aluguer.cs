using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    partial class Aluguer
    {
        public Aluguer(DateTime dataInicio, DateTime dataFim, decimal valor, int kms)
        {
            DataInicio = dataInicio;
            DataFim = dataFim;
            Valor = valor;
            Kms = kms;
        }

        public override string ToString()
        {
            return +Valor + " € [" + DataInicio.ToShortDateString() + " a " + DataFim.ToShortDateString() + "]";// + " ( " + Kms + " ) ";
        }

        public Aluguer()
        {
        }
    }
}
