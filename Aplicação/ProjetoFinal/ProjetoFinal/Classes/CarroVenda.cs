using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    partial class CarroVenda
    {
        public CarroVenda(string numeroChassis, string marca, string modelo, string combustivel, string extras)
        {
            NumeroChassis = numeroChassis ?? throw new ArgumentNullException(nameof(numeroChassis));
            Marca = marca ?? throw new ArgumentNullException(nameof(marca));
            Modelo = modelo ?? throw new ArgumentNullException(nameof(modelo));
            Combustivel = combustivel ?? throw new ArgumentNullException(nameof(combustivel));
            Extras = extras ?? throw new ArgumentNullException(nameof(extras));
        }

        public override string ToString()
        {
            return "[" + NumeroChassis + "] - " + Marca + " (" + Modelo + ")";

        }

        public CarroVenda()
        {
        }
    }
}
