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


    public partial class AlugueresCarrosAdicionar : Form
    {
        oficinaDBContainer standDB;
        Cliente clienteAtual;
        CarroAluguer carroAluguerAtual;

        public AlugueresCarrosAdicionar(oficinaDBContainer dBContainer, Cliente cliente, CarroAluguer carroAtual)
        {
            InitializeComponent();
            standDB = dBContainer;
            clienteAtual = cliente;
            carroAluguerAtual = carroAtual;
        }

        //Código que só é executado após o botão "Adicionar" seja clicado
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            //Codigo que irá adicionar um carro de aluguer á database
            if (AreTextBoxesValid() == true)
            {
                CarroAluguer novoCarroAluguer = new CarroAluguer(textBoxNumeroChassis.Text, textBoxMarca.Text, textBoxModelo.Text, textBoxCombustivel.Text, textBoxMatricula.Text, textBoxEstado.Text);

                standDB.Carros.Add(novoCarroAluguer);
                standDB.SaveChanges();
                MessageBox.Show("Novo carro de oficina adicionado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //Código que ativa ou desativa a caixa de texto "Estado" ao fazer Double Click
        private void textBoxEstado_DoubleClick(object sender, EventArgs e)
        {
            textBoxEstado.ReadOnly = !textBoxEstado.ReadOnly;
        }
    }
}
