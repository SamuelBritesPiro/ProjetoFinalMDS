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
    public partial class OficinaCarrosGestao : Form
    {
        oficinaDBContainer standDB;
        Cliente clienteAtual;
        CarroOficina carroOficinaAtual;


        public OficinaCarrosGestao(oficinaDBContainer dBContainer, Cliente cliente, CarroOficina carroOficina)
        {
            InitializeComponent();
            standDB = dBContainer;
            clienteAtual = cliente;
            carroOficinaAtual = carroOficina;
        }


        private void OficinaGestaoCarros_Load(object sender, EventArgs e)
        {
            //Atualiza as caixas de texto com a informação do carro de oficina selecionado
            textBoxNumeroChassis.Text = carroOficinaAtual.NumeroChassis;
            textBoxMarca.Text = carroOficinaAtual.Marca;
            textBoxModelo.Text = carroOficinaAtual.Modelo;
            textBoxCombustivel.Text = carroOficinaAtual.Combustivel;
            textBoxMatricula.Text = carroOficinaAtual.Matricula;
            textBoxQuilometros.Text = carroOficinaAtual.Kms.ToString();
        }

        //Código que só é executado após o botão "Eliminar" seja clicado
        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            //Codigo que irá eliminar um carro de oficina á database



            if (carroOficinaAtual.Servicos.Count == 0)
            {
                if (Confirmacao("eliminar", "carro de oficina") == DialogResult.Yes)
                {
                    standDB.Carros.Remove(carroOficinaAtual);
                    standDB.SaveChanges();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Para que este carro de oficina seja eliminado, não poderá haver serviços associados.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        //Código que só é executado após o botão "Editar" seja clicado
        private void buttonEditar_Click(object sender, EventArgs e)
        {

            //Codigo que irá editar um carro de oficina á database
            if (AreTextBoxesValid() == true)
            {
                if (Confirmacao("editar", "carro de oficina") == DialogResult.Yes)
                {
                    carroOficinaAtual.NumeroChassis = textBoxNumeroChassis.Text;
                    carroOficinaAtual.Marca = textBoxMarca.Text;
                    carroOficinaAtual.Modelo = textBoxModelo.Text;
                    carroOficinaAtual.Combustivel = textBoxCombustivel.Text;
                    carroOficinaAtual.Matricula = textBoxMatricula.Text;
                    carroOficinaAtual.Kms = Int32.Parse(textBoxQuilometros.Text);

                    standDB.SaveChanges();

                    MessageBox.Show("Carro de oficina editado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Necessita de ter todas as caixas de texto preenchidas e com valores válidos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        //Código que irá fazer uma pergunta e devolve a resposta
        private DialogResult Confirmacao(string funcao = "função", string tipo = "tipo")
        {
            DialogResult result = DialogResult.No;

            result = MessageBox.Show("Tem a certeza que deseja " + funcao + " o(a) seguinte " + tipo + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return result;
        }


        //Código que só é executado quando algo é escrito na caixa de texto Quilometros
        private void textBoxQuilometros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //A tecla primida só é aceitada caso seja um numero ou um caracter de controlo (ex: Enter)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        //Código que irá verificar se as caixas de texto estão preenchidas
        private bool AreTextBoxesValid()
        {
            bool resultado = false;
            int i;

            if (textBoxNumeroChassis.Text != "" &&
                textBoxMarca.Text != "" &&
                textBoxModelo.Text != "" &&
                textBoxCombustivel.Text != "" &&
                textBoxMatricula.Text != "" &&
                textBoxQuilometros.Text != ""
                && int.TryParse(textBoxQuilometros.Text, out i))
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
