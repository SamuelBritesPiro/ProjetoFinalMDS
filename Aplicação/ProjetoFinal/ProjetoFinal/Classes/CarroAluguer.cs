using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    partial class CarroAluguer
    {
        public CarroAluguer(string numeroChassis, string marca, string modelo, string combustivel, string matricula, string estado)
        {
            NumeroChassis = numeroChassis;
            Marca = marca;
            Modelo = modelo;
            Combustivel = combustivel;
            Matricula = matricula;
            Estado = estado;
            this.Aluguer = new HashSet<Aluguer>();
        }

        public override string ToString()
        {
            return "[" + Estado + "] - [" + NumeroChassis + "] - " + Marca + " (" + Matricula + ")";//+ " {" + Combustivel + "} (" + Matricula + ") ";
        }
    }
}
