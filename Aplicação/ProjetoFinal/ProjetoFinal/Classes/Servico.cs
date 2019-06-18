using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    partial class Servico
    {

        public Servico(DateTime dataEntrada, string tipo, DateTime dataSaida)
        {
            DataEntrada = dataEntrada;
            Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
            DataSaida = dataSaida;
            Parcelas = new HashSet<Parcela>();
        }

        public override string ToString()
        {
            return Tipo + "[" + DataEntrada.ToShortDateString() + " a " + DataSaida.ToShortDateString() + "]";
        }

        public decimal TotalParcelas()
        {
            decimal total = 0;

            foreach (Parcela parcela in Parcelas)
            {
                total += parcela.Valor;
            }


            return total;
        }
    }
}
