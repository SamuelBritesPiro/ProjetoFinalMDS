using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    partial class Cliente
    {
        public Cliente(string nome, int nif, string morada, int contacto)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Nif = nif;
            Morada = morada ?? throw new ArgumentNullException(nameof(morada));
            Contacto = contacto;
        }

        public override string ToString()
        {
            return Nome + " " + Nif + " " + Morada + " " + Contacto;
        }
    }
}
