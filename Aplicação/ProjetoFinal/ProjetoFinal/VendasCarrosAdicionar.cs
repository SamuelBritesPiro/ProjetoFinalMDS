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
    public partial class VendasCarrosAdicionar : Form
    {
        oficinaDBContainer standDB;


        public VendasCarrosAdicionar(oficinaDBContainer dBContainer)
        {
            InitializeComponent();
            standDB = dBContainer;
        }

        //Código que só é executado após o botão "Adicionar" seja clicado
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            //Codigo que irá adicionar um carro de venda á database

            if (AreTextBoxesValid() == true)
            {
                CarroVenda novoCarroVenda = new CarroVenda(textBoxNumeroChassis.Text, textBoxMarca.Text, textBoxModelo.Text, textBoxCombustivel.Text, textBoxExtras.Text);
                standDB.Carros.Add(novoCarroVenda);
                standDB.SaveChanges();
                MessageBox.Show("Novo carro de venda adicionado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

    }
}
