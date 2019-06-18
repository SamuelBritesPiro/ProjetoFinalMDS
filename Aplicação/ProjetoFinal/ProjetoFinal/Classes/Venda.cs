using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    partial class Venda
    {
        public Venda(decimal valor, string estado, DateTime data)
        {
            Valor = valor;
            Estado = estado ?? throw new ArgumentNullException(nameof(estado));
            Data = data;
        }

        public override string ToString()
        {
            return Estado + "(" + Valor + ") - " + Data;
        }

        public Venda()
        {
        }
    }
}
