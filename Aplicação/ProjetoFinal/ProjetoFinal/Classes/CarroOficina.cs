using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    partial class CarroOficina
    {
        public CarroOficina(string numeroChassis, string marca, string modelo, string combustivel, string matricula, int kms)
        {
            NumeroChassis = numeroChassis;
            Marca = marca;
            Modelo = modelo;
            Combustivel = combustivel;
            Matricula = matricula;
            Kms = kms;
            Servicos = new HashSet<Servico>();

        }

        public override string ToString()
        {
            return "[" + NumeroChassis + "] - " + Marca + "( " + Matricula + " )";
        }

        public decimal TotalServicos()
        {
            decimal totalServicos = 0;

            foreach (Servico servico in Servicos)
            {
                totalServicos += servico.TotalParcelas();
            }


            return totalServicos;
        }
    }
}
