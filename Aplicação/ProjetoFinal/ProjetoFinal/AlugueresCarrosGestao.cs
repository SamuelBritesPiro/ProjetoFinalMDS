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
    public partial class AlugueresCarrosGestao : Form
    {
        oficinaDBContainer standDB;
        CarroAluguer carroAluguerAtual;

        public AlugueresCarrosGestao(oficinaDBContainer dBContainer, CarroAluguer carroAluguer)
        {
            InitializeComponent();
            standDB = dBContainer;
            carroAluguerAtual = carroAluguer;
        }

        private void AluguerCarrosGestao_Load(object sender, EventArgs e)
        {
            //Irá atualizar as caixas de texto de acordo com o carro de aluguer selecionado
            if (carroAluguerAtual != null)
            {
                textBoxNumeroChassis.Text = carroAluguerAtual.NumeroChassis;
                textBoxMarca.Text = carroAluguerAtual.Marca;
                textBoxModelo.Text = carroAluguerAtual.Modelo;
                textBoxCombustivel.Text = carroAluguerAtual.Combustivel;
                textBoxMatricula.Text = carroAluguerAtual.Matricula;
                textBoxEstado.Text = carroAluguerAtual.Estado;
            }
            else
            {
                MessageBox.Show("Carro de aluguer não escolhido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

        }

        //Código que irá fazer uma pergunta e devolve a resposta
        private DialogResult Confirmacao(string funcao = "função", string tipo = "tipo")
        {
            DialogResult result = DialogResult.No;

            result = MessageBox.Show("Tem a certeza que deseja " + funcao + " o(a) seguinte " + tipo + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return result;
        }

        //Código que irá verificar se as caixas de texto estão preenchidas
        private bool AreTextBoxesValid()
        {
            bool resultado = false;

            if (textBoxNumeroChassis.Text != "" &&
                textBoxMarca.Text != "" &&
                textBoxModelo.Text != "" &&
                textBoxCombustivel.Text != "" &&
                textBoxMatricula.Text != "" &&
                textBoxEstado.Text != "")
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
        }

        //Código que só é executado após o botão "Editar" seja clicado
        private void buttonEditar_Click(object sender, EventArgs e)
        {

            //Codigo que irá editar um carro de aluguer á database

            if (AreTextBoxesValid() == true)
            {
                if (Confirmacao("editar", "carro de aluguer") == DialogResult.Yes)
                {
                    CarroAluguer carroASerEditado = carroAluguerAtual;

                    carroASerEditado.NumeroChassis = textBoxNumeroChassis.Text;
                    carroASerEditado.Marca = textBoxMarca.Text;
                    carroASerEditado.Modelo = textBoxModelo.Text;
                    carroASerEditado.Combustivel = textBoxCombustivel.Text;
                    carroASerEditado.Matricula = textBoxMatricula.Text;
                    carroASerEditado.Estado = textBoxEstado.Text;

                    standDB.SaveChanges();
                    MessageBox.Show("Carro de aluguer editado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

            }
            else
            {
                MessageBox.Show("Necessita de ter todas as caixas de texto preenchidas e com valores válidos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Código que só é executado após o botão "Eliminar" seja clicado

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //Codigo que irá eliminar um carro de aluguer á database

            if (carroAluguerAtual.Aluguer.Count == 0)
            {
                if (Confirmacao("eliminar", "de aluguer") == DialogResult.Yes)
                {
                    standDB.Carros.Remove(carroAluguerAtual);
                    standDB.SaveChanges();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Não pode haver alugueres associados, para que este carro de aluguer seja eliminado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Código que ativa ou desativa a caixa de texto "Estado" ao fazer Double Click
        private void textBoxEstado_DoubleClick(object sender, EventArgs e)
        {
            textBoxEstado.ReadOnly = !textBoxEstado.ReadOnly;
        }
    }
}
