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
    public partial class VendasCarrosGestao : Form
    {
        oficinaDBContainer standDB;
        CarroVenda carroVendaAtual;

        public VendasCarrosGestao(oficinaDBContainer dBContainer, CarroVenda carroVenda)
        {
            InitializeComponent();
            standDB = dBContainer;
            carroVendaAtual = carroVenda;
        }

        //Código que só é executado após o botão "Editar" seja clicado
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //Codigo que irá editar um carro de venda á database

            if (AreTextBoxesValid() == true)
            {
                if (Confirmacao("editar", "carro de venda") == DialogResult.Yes)
                {
                    carroVendaAtual.NumeroChassis = textBoxNumeroChassis.Text;
                    carroVendaAtual.Marca = textBoxMarca.Text;
                    carroVendaAtual.Modelo = textBoxModelo.Text;
                    carroVendaAtual.Combustivel = textBoxCombustivel.Text;
                    carroVendaAtual.Extras = textBoxExtras.Text;
                    standDB.SaveChanges();
                    MessageBox.Show("Carro de venda editado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
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

            if (textBoxNumeroChassis.Text != "" &&
                textBoxMarca.Text != "" &&
                textBoxModelo.Text != "" &&
                textBoxCombustivel.Text != "" &&
                textBoxExtras.Text != "")
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
        }

        //Código que só é executado após o botão "Eliminar" seja clicado
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //Codigo que irá eliminar um carro de venda á database


            if (carroVendaAtual.Venda == null)
            {

                if (Confirmacao("eliminar", "carro de venda") == DialogResult.Yes)
                {
                    standDB.Carros.Remove(carroVendaAtual);
                    standDB.SaveChanges();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Carro de venda já está associado a uma venda, não pode ser eliminado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        //Código que irá fazer uma pergunta e devolve a resposta
        private DialogResult Confirmacao(string funcao = "função", string tipo = "tipo")
        {
            DialogResult result = DialogResult.No;

            result = MessageBox.Show("Tem a certeza que deseja " + funcao + " o(a) seguinte " + tipo + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return result;
        }

        private void VendasCarrosGestao_Load(object sender, EventArgs e)
        {
            //Atualiza as caixas de texto com a informação do carro de venda selecionado
            if (carroVendaAtual != null)
            {
                textBoxNumeroChassis.Text = carroVendaAtual.NumeroChassis;
                textBoxMarca.Text = carroVendaAtual.Marca;
                textBoxModelo.Text = carroVendaAtual.Modelo;
                textBoxCombustivel.Text = carroVendaAtual.Combustivel;
                textBoxExtras.Text = carroVendaAtual.Extras;
            }
        }
    }
}
