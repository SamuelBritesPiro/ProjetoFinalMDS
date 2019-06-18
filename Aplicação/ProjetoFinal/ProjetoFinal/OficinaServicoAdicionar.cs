using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class OficinaServicoAdicionar : Form
    {
        oficinaDBContainer standDB;
        Cliente clienteAtual;
        CarroOficina carroOficinaAtual;


        public OficinaServicoAdicionar(oficinaDBContainer dBContainer, Cliente cliente, CarroOficina carro)
        {
            InitializeComponent();
            standDB = dBContainer;
            clienteAtual = cliente;
            carroOficinaAtual = carro;

        }

        //Código que só é executado após o botão "Adicionar" seja clicado
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            //Codigo que irá adicionar um serviço á database
            if (AreTextBoxesValid() == true)
            {
                Servico novoServico = new Servico(DateTime.Parse(dateTimePickerEntrada.Text), textBoxTipo.Text, DateTime.Parse(dateTimePickerSaida.Text));
                carroOficinaAtual.Servicos.Add(novoServico);
                standDB.SaveChanges();
                MessageBox.Show("Novo serviço adicionado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Necessita de ter todas as caixas de texto preenchidas e com valores válidos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Código que irá verificar se as caixas de texto estão preenchidas
        private bool AreTextBoxesValid()
        {
            bool resultado = false;

            if (dateTimePickerEntrada.Text != "" &&
                textBoxTipo.Text != "" &&
                dateTimePickerSaida.Text != "")
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
        }
    }
}
