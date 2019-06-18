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
    public partial class OficinaServicoGestao : Form
    {
        oficinaDBContainer standDB;
        Cliente clienteAtual;
        CarroOficina carroOficinaAtual;
        Servico servicoAtual;


        public OficinaServicoGestao(oficinaDBContainer dBContainer, Cliente cliente, CarroOficina carro, Servico servico)
        {
            InitializeComponent();
            standDB = dBContainer;
            clienteAtual = cliente;
            carroOficinaAtual = carro;
            servicoAtual = servico;
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

        //Código que só é executado após o botão "Editar" seja clicado
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //Codigo que irá editar um serviço á database
            if (AreTextBoxesValid() == true)
            {

                if (Confirmacao("editar", "serviço") == DialogResult.Yes)
                {
                    servicoAtual.DataEntrada = dateTimePickerEntrada.Value;
                    servicoAtual.Tipo = textBoxTipo.Text;
                    servicoAtual.DataSaida = dateTimePickerSaida.Value;
                    standDB.SaveChanges();

                    MessageBox.Show("Serviço editado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //Codigo que irá eliminar um serviço á database
            if (servicoAtual.Parcelas.Count == 0)
            {
                if (Confirmacao("eliminar", "serviço") == DialogResult.Yes)
                {
                    standDB.Servicos.Remove(servicoAtual);
                    standDB.SaveChanges();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Para que este serviço seja eliminado, não poderá haver parcelas asociadas a ele.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Código que irá fazer uma pergunta e devolve a resposta
        private DialogResult Confirmacao(string funcao = "função", string tipo = "tipo")
        {
            DialogResult result = DialogResult.No;

            result = MessageBox.Show("Tem a certeza que deseja " + funcao + " o(a) seguinte " + tipo + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return result;
        }

        private void OficinaServicoGestao_Load(object sender, EventArgs e)
        {
            //Atualiza as caixas de texto com a informação do serviço selecionado
            dateTimePickerEntrada.Text = servicoAtual.DataEntrada.ToShortDateString();
            textBoxTipo.Text = servicoAtual.Tipo;
            dateTimePickerSaida.Text = servicoAtual.DataSaida.ToShortDateString();
        }
    }
}
