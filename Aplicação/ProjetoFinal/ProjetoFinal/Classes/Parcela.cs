using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    partial class Parcela
    {
        public Parcela(decimal valor, string descricao)
        {
            Valor = valor;
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
        }

        public Parcela() { }

        public override string ToString()
        {
            return Descricao + "(" + Valor.ToString("N2") + ")";
        }


    }
}
