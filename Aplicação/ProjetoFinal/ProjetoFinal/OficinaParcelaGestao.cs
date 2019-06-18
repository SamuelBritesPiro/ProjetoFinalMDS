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
    public partial class OficinaParcelaGestao : Form
    {
        oficinaDBContainer standDB;
        Cliente clienteAtual;
        CarroOficina carroOficinaAtual;
        Servico servicoAtual;
        Parcela parcelaAtual;

        public OficinaParcelaGestao(oficinaDBContainer dBContainer, Cliente cliente, CarroOficina carroOficina, Servico servico, Parcela parcela)
        {
            InitializeComponent();

            standDB = dBContainer;
            clienteAtual = cliente;
            carroOficinaAtual = carroOficina;
            servicoAtual = servico;
            parcelaAtual = parcela;
        }

        //Código que irá verificar se as caixas de texto estão preenchidas
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

        //Código que só é executado quando algo é escrito na caixa de texto valor
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

        private void OficinaParcelaGestao_Load(object sender, EventArgs e)
        {
            //Atualiza as caixas de texto com a informação da parcela selecionado
            textBoxValor.Text = parcelaAtual.Valor.ToString();
            textBoxDescricao.Text = parcelaAtual.Descricao;
        }


        //Código que só é executado após o botão "Editar" seja clicado
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //Codigo que irá editar uma parcala á database
            if (AreTextBoxesValid() == true)
            {
                if (Confirmacao("editar", "parcela") == DialogResult.Yes)
                {
                    parcelaAtual.Valor = decimal.Parse(textBoxValor.Text);
                    parcelaAtual.Descricao = textBoxDescricao.Text;

                    servicoAtual.Parcelas.Add(parcelaAtual);
                    standDB.SaveChanges();
                    MessageBox.Show("Parcela editada com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Necessita de ter todas as caixas de texto preenchidas e com valores válidos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Código que só é executado após o botão "Eliminar" seja 
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //Codigo que irá eliminar uma parcela á database
            if (Confirmacao("eliminar", "parcela") == DialogResult.Yes)
            {
                standDB.Parcelas.Remove(parcelaAtual);
                standDB.SaveChanges();
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
    }
}
