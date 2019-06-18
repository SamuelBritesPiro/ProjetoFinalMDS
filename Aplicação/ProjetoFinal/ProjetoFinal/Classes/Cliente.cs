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
            Nome = nome;
            Nif = nif;
            Morada = morada;
            Contacto = contacto;
            CarrosOficina = new HashSet<CarroOficina>();
            Vendas = new HashSet<Venda>();
            Alugueres = new HashSet<Aluguer>();
        }


        public override string ToString()
        {
            return "[" + Nif + "] - " + Nome + " (" + Contacto + ")"; // + " {" + Morada + "} ";
        }

        public decimal TotalCarrosOficina()
        {
            decimal total = 0;

            foreach (CarroOficina carro in CarrosOficina)
            {
                total += carro.TotalServicos();
            }


            return total;
        }



    }
}
