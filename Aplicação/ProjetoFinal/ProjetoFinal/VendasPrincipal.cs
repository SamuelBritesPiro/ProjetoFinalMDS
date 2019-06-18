using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class VendasPrincipal : Form
    {
        oficinaDBContainer standDB;
        Cliente clienteAtual;
        Venda vendaAtual;
        CarroVenda carroVendaAtual;


        public VendasPrincipal(oficinaDBContainer dBContainer)
        {
            InitializeComponent();
            standDB = dBContainer;
        }

        private void VendasPrincipal_Load(object sender, EventArgs e)
        {
            //Irá listar os clientes, carros de venda e vendas 
            ListarClientes();
            ListarCarrosDeVendas();
            ListarVendas();
            listBoxVendas.SelectedIndex = -1;
            listBoxCarros.SelectedIndex = -1;
            listBoxClientes.SelectedIndex = -1;
        }

        //Código que irá atualizar a lista de clientes
        private void ListarClientes()
        {
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = standDB.Clientes.ToList();
            listBoxClientes.SelectedIndex = -1;
        }

        //Código que irá atualizar a lista de carros de venda
        private void ListarCarrosDeVendas()
        {
            listBoxCarros.DataSource = null;
            listBoxCarros.DataSource = standDB.Carros.OfType<CarroVenda>().ToList();
            listBoxCarros.SelectedIndex = -1;
        }

        //Código que irá atualizar a lista de vendas
        private void ListarVendas()
        {
            listBoxVendas.DataSource = null;
            listBoxVendas.DataSource = standDB.Vendas.ToList();
            listBoxVendas.SelectedIndex = -1;
        }

        //Código que só é executado após o clientes selecionado na listbox seja mudado
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Código que irá atualizar os labels do form
            if (listBoxClientes.SelectedIndex > -1)
            {
                clienteAtual = (Cliente)listBoxClientes.SelectedItem;
                labelNomeCliente.Text = clienteAtual.Nome;
                labelNumeroCliente.Text = clienteAtual.Contacto.ToString();
                labelMoradaCliente.Text = clienteAtual.Morada;
            }
            else
            {
                clienteAtual = null;
                labelNomeCliente.Text = "Nenhum cliente selecionado";
                labelNumeroCliente.Text = "-";
                labelMoradaCliente.Text = "-";
                //labelValorTotal.Text = "0";
            }


        }

        //Código que só é executado após o botão "Adicionar carro de venda" seja clicado
        private void buttonAddCarroDeVenda_Click(object sender, EventArgs e)
        {
            //Código que irá abrir o form de adicionar carro de venda
            VendasCarrosAdicionar vendasCarrosAdicionar = new VendasCarrosAdicionar(standDB);
            vendasCarrosAdicionar.ShowDialog();
            ListarCarrosDeVendas();
        }

        //Código que só é executado após o botão "Gestão carro de venda" seja clicado
        private void buttonGestaoCarroDeVenda_Click(object sender, EventArgs e)
        {
            //Código que irá abrir o form de gestão do carro de venda
            if (carroVendaAtual != null)
            {
                VendasCarrosGestao vendasCarrosGestao = new VendasCarrosGestao(standDB, carroVendaAtual);
                vendasCarrosGestao.ShowDialog();
                ListarCarrosDeVendas();
            }
            else
            {
                MessageBox.Show("Necessita de um carro de venda selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //Código que só é executado após o carro de venda selecionado na listbox seja mudado
        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Irá atualizar o carro de venda selecionado
            if (listBoxCarros.SelectedIndex > -1)
            {
                carroVendaAtual = (CarroVenda)listBoxCarros.SelectedItem;
            }
            else
            {
                carroVendaAtual = null;
            }
        }

        //Código que só é executado após a vendas selecionada na listbox seja mudada
        private void listBoxVendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Código que irá atualizar a venda selecionada
            if (listBoxVendas.SelectedIndex > -1)
            {
                vendaAtual = (Venda)listBoxVendas.SelectedItem;
                listBoxClientes.SelectedItem = vendaAtual.Cliente;
                listBoxCarros.SelectedItem = vendaAtual.CarroVenda;
            }
            else
            {
                vendaAtual = null;
            }
        }

        //Código que irá verificar se as caixas de texto estão preenchidas
        private bool AreTextBoxesValid()
        {
            bool resultado = false;
            int i;

            if (dateTimePickerVenda.Text != "" &&
                textBoxValor.Text != "" &&
                textBoxEstado.Text != ""
                && int.TryParse(textBoxValor.Text, out i))
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
        }

        //Código que só é executado após o botão "Criar Venda" seja clicado
        private void buttonCriarVenda_Click(object sender, EventArgs e)
        {
            //Codigo que irá adicionar uma venda á database
            if (clienteAtual != null && carroVendaAtual != null)
            {
                if (AreTextBoxesValid() == true)
                {
                    if (carroVendaAtual.Venda == null)
                    {
                        DateTime data = dateTimePickerVenda.Value;
                        decimal valor = decimal.Parse(textBoxValor.Text);
                        string estado = textBoxEstado.Text;

                        Venda novaVenda = new Venda(valor, estado, data);

                        novaVenda.CarroVenda = carroVendaAtual;
                        clienteAtual.Vendas.Add(novaVenda);
                        standDB.SaveChanges();

                        ListarCarrosDeVendas();
                        ListarVendas();
                    }
                    else
                    {
                        MessageBox.Show("Este carro já foi vendido.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Necessita de ter todas as caixas de texto preenchidas e com valores válidos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Necessita de um cliente e de um carro de venda selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Código que irá fazer uma pergunta e devolve a resposta
        private DialogResult Confirmacao(string funcao = "função", string tipo = "tipo")
        {
            DialogResult result = DialogResult.No;

            result = MessageBox.Show("Tem a certeza que deseja " + funcao + " o(a) seguinte " + tipo + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return result;
        }

        //Código que só é executado após o botão "Filtrar" seja clicado
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
            textBoxFiltrar.Clear();
        }

        /* Código que atualiza a listbox dos clientes de acordo com o nome que se coloca na caixa de texto
        * A filtração foi feita com a ajuda deste video: https://www.youtube.com/watch?v=w5vZiemB06c
       */
        private void Filtrar()
        {
            if (textBoxFiltrar.Text != "")
            {
                listBoxClientes.DataSource = null;
                listBoxClientes.DataSource = standDB.Clientes.Where(x => x.Nome.Contains(textBoxFiltrar.Text)).ToList();
                listBoxClientes.SelectedIndex = -1;
                clienteAtual = null;

            }
            else
            {
                ListarClientes();
            }
        }

        //Código que só é executado quando algo é escrito na caixa de texto filtrar
        private void textBoxFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxFiltrar.Clear();
            }
            Filtrar();
        }

        //Código que só é executado após o botão "Imprimir" seja clicado
        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            //Código que irá escrever num ficheiro o recibo do aluguer selecionado
            if (vendaAtual != null)
            {
                string fileLocation = null;

                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFileDialog.Filter = "Text files (*.txt, *.dat)|*.txt;*.dat";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.RestoreDirectory = true;


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileLocation = saveFileDialog.FileName;

                    string[] text = {
                        "Recibo: ",
                        "Nome do cliente: " + vendaAtual.Cliente.Nome,
                        "Morada do cliente: " + vendaAtual.Cliente.Morada,
                        "NIF do cliente: " + vendaAtual.Cliente.Nif,
                        "Data da venda: " + vendaAtual.Data.ToShortDateString(),
                        "Valor da venda: " + vendaAtual.Valor,
                        "Estado da venda: " + vendaAtual.Estado,
                         };

                    using (StreamWriter outputFile = new StreamWriter(fileLocation))
                    {
                        foreach (string line in text)
                            outputFile.WriteLine(line);
                    }

                }
            }
            else
            {
                MessageBox.Show("Necessita de ter um aluguer selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}
