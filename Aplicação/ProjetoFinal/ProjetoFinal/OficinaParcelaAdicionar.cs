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
    public partial class OficinaParcelaAdicionar : Form
    {
        oficinaDBContainer standDB;
        Cliente clienteAtual;
        CarroOficina carroOficinaAtual;
        Servico servicoAtual;

        public OficinaParcelaAdicionar(oficinaDBContainer dBContainer, Cliente cliente, CarroOficina carroOficina, Servico servico)
        {
            InitializeComponent();
            standDB = dBContainer;
            clienteAtual = cliente;
            carroOficinaAtual = carroOficina;
            servicoAtual = servico;
        }

        //Código que só é executado quando algo é escrito na caixa de texto Valor
        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //A tecla primida só é aceitada caso seja um numero ou um caracter de controlo (ex: Enter)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Apenas pode ter uma casa decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        //Código que só é executado após o botão "Adicionar" seja clicado
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            //Codigo que irá adicionar uma parcela á database
            if (AreTextBoxesValid() == true)
            {
                Parcela novaParcela = new Parcela(decimal.Parse(textBoxValor.Text), textBoxDescricao.Text);
                servicoAtual.Parcelas.Add(novaParcela);
                standDB.SaveChanges();
                MessageBox.Show("Nova parcela adicionada com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Necessita de ter todas as caixas de texto preenchidas e com valores válidos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Código que irá verificar se as caixas de texto estão válidas
        private bool AreTextBoxesValid()
        {
            bool resultado = false;
            decimal i;

            if (textBoxValor.Text != "" &&
                textBoxDescricao.Text != "" && decimal.TryParse(textBoxValor.Text, out i))
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
