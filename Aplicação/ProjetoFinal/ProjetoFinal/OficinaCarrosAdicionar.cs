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
    public partial class OficinaCarrosAdicionar : Form
    {
        oficinaDBContainer standDB;
        Cliente clienteAtual;

        public OficinaCarrosAdicionar(oficinaDBContainer oficinaDB, Cliente cliente)
        {
            InitializeComponent();
            standDB = oficinaDB;
            clienteAtual = cliente;
        }

        //Código que só é executado após o botão "Adicionar" seja clicado
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            //Código que irá adicionar um carro de oficina á database
            if (AreTextBoxesValid() == true)
            {
                CarroOficina novoCarroOficina = new CarroOficina(textBoxNumeroChassis.Text, textBoxMarca.Text, textBoxModelo.Text, textBoxCombustivel.Text, textBoxMatricula.Text, Int32.Parse(textBoxQuilometros.Text));

                clienteAtual.CarrosOficina.Add(novoCarroOficina);
                standDB.SaveChanges();
                MessageBox.Show("Novo carro de aluguer adicionado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            int i;

            if (textBoxNumeroChassis.Text != "" &&
                textBoxMarca.Text != "" &&
                textBoxModelo.Text != "" &&
                textBoxCombustivel.Text != "" &&
                textBoxMatricula.Text != "" &&
                textBoxQuilometros.Text != "" && int.TryParse(textBoxQuilometros.Text, out i))
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
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
    }
}
