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
    public partial class AlugueresPrincipal : Form
    {
        oficinaDBContainer standDB;
        Cliente clienteAtual;
        CarroAluguer carroAluguerAtual;
        Aluguer aluguerAtual;

        public AlugueresPrincipal(oficinaDBContainer dBContainer)
        {
            InitializeComponent();
            standDB = dBContainer;
        }

        //Código que só é executado após o botão "Adicionar Carro de Aluguer" seja clicado
        private void buttonAddCarro_Click(object sender, EventArgs e)
        {
            //Código que irá abrir o form de adicionar carro de aluguer
            AlugueresCarrosAdicionar gestaoDeAlugueresAdicionar = new AlugueresCarrosAdicionar(standDB, clienteAtual, carroAluguerAtual);
            gestaoDeAlugueresAdicionar.ShowDialog();
            ListarCarrosDeAluguer();
        }

        private void AlugueresPrincipal_Load(object sender, EventArgs e)
        {
            //Irá listar os clientes, caros de aluguer e alugueres
            ListarClientes();
            ListarCarrosDeAluguer();
            ListarAlugueres();
        }

        //Código que irá atualizar a lista de clientes
        private void ListarClientes()
        {
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = standDB.Clientes.ToList();
            listBoxClientes.SelectedIndex = -1;
        }

        //Código que irá atualizar a lista de carros de aluguer
        private void ListarCarrosDeAluguer()
        {
            listBoxCarros.DataSource = null;
            listBoxCarros.DataSource = standDB.Carros.OfType<CarroAluguer>().ToList();
            listBoxCarros.SelectedIndex = -1;


        }

        //Código que só é executado após o cliente selecionado na listbox seja mudado
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Código que atualiza os labels
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
            }
        }

        //Código que só é executado após o carros de alugueres selecionado na listbox seja mudado
        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            carroAluguerAtual = null;

            if (listBoxCarros.SelectedIndex > -1)
            {
                carroAluguerAtual = (CarroAluguer)listBoxCarros.SelectedItem;
            }
        }

        //Código que atualiza a listbox dos alugueres
        private void ListarAlugueres()
        {

            listBoxAlugueres.DataSource = null;
            listBoxAlugueres.DataSource = standDB.Alugueres.ToList();
            listBoxAlugueres.SelectedIndex = -1;

        }

        //Código que irá verificar se as caixas de texto estão preenchidas
        private bool AreTextBoxesValid()
        {
            bool resultado = false;
            int i;

            if (dateTimePickerInicio.Text != "" &&
                dateTimePickerFim.Text != "" &&
                textBoxValor.Text != "" &&
                textBoxKms.Text != ""
                && int.TryParse(textBoxValor.Text, out i)
                && int.TryParse(textBoxKms.Text, out i))
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
        }

        //Código que só é executado após o botão "Gestão de carro de aluguer" seja clicado
        private void buttonGestaoCarroDeAluguer_Click(object sender, EventArgs e)
        {
            //Código que irá abrir o form de gestão carro de aluguer
            if (carroAluguerAtual != null)
            {
                AlugueresCarrosGestao gestaoDeAlugueresEditar = new AlugueresCarrosGestao(standDB, carroAluguerAtual);
                gestaoDeAlugueresEditar.ShowDialog();
                ListarCarrosDeAluguer();
            }
            else
            {
                MessageBox.Show("Necessita de ter um carro de aluguer selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //Código que só é executado quando algo é escrito na caixa de texto Kms
        private void textBoxKms_KeyPress(object sender, KeyPressEventArgs e)
        {
            //A tecla primida só é aceitada caso seja um numero ou um caracter de controlo (ex: Enter
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Código que só é executado após o botão "Criar aluguer" seja clicado
        private void buttonCriarAluguer_Click(object sender, EventArgs e)
        {
            //Codigo que irá adicionar um aluguer á database
            if (clienteAtual != null && carroAluguerAtual != null)
            {
                if (clienteAtual.Alugueres.Count == 0)
                {
                    if (carroAluguerAtual.Estado != "Alugado")
                    {
                        if (AreTextBoxesValid() == true)
                        {
                            DateTime dataInicial = dateTimePickerInicio.Value;
                            DateTime dataFinal = dateTimePickerFim.Value;
                            decimal valor = decimal.Parse(textBoxValor.Text);
                            int kms = Int32.Parse(textBoxKms.Text);

                            Aluguer novoAluguer = new Aluguer(dataInicial, dataFinal, valor, kms);

                            carroAluguerAtual.Estado = "Alugado";


                            novoAluguer.CarroAluguer = carroAluguerAtual;
                            clienteAtual.Alugueres.Add(novoAluguer);
                            standDB.SaveChanges();

                            ListarCarrosDeAluguer();
                            ListarAlugueres();

                            textBoxKms.Clear();
                            textBoxValor.Clear();


                        }
                        else
                        {
                            MessageBox.Show("Necessita de ter todas as caixas de texto preenchidas e com valores válidos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este carro já se encontra alugado, terá de escolher outro.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Esse cliente já possui um carro alugado.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Necessita de ter um cliente e um carro de aluguer selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Código que só é executado após o botão "Eliminar aluguer" seja clicado
        private void buttonEliminarAluguer_Click(object sender, EventArgs e)
        {
            //Codigo que irá eliminar um aluguer á database
            if (aluguerAtual != null)
            {
                if (Confirmacao("eliminar", "aluguer") == DialogResult.Yes)
                {
                    aluguerAtual.CarroAluguer.Estado = "Por alugar";
                    standDB.Alugueres.Remove(aluguerAtual);
                    standDB.SaveChanges();
                    ListarCarrosDeAluguer();
                    ListarAlugueres();
                }
            }
            else
            {
                MessageBox.Show("Necessita de ter um aluguer selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Código que irá fazer uma pergunta e devolve a resposta
        private DialogResult Confirmacao(string funcao = "função", string tipo = "tipo")
        {
            DialogResult result = DialogResult.No;

            result = MessageBox.Show("Tem a certeza que deseja " + funcao + " o(a) seguinte " + tipo + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return result;
        }

        //Código que só é executado após o aluguer selecionado na listbox seja mudado
        private void listBoxAlugueres_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Define o aluguer atual

            aluguerAtual = null;
            listBoxClientes.SelectedIndex = -1;
            listBoxCarros.SelectedIndex = -1;

            if (listBoxAlugueres.SelectedIndex > -1)
            {
                aluguerAtual = (Aluguer)listBoxAlugueres.SelectedItem;
                listBoxClientes.SelectedItem = aluguerAtual.Cliente;
                listBoxCarros.SelectedItem = aluguerAtual.CarroAluguer;
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

        //Código que só é executado após o botão "Imprimir" seja clicado
        private void buttonImprimir_Click(object sender, EventArgs e)
        {

            //Código que irá escrever num ficheiro o recibo do aluguer selecionado
            if (aluguerAtual != null)
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
                        "Nome do cliente: " + aluguerAtual.Cliente.Nome,
                        "Morada do cliente: " + aluguerAtual.Cliente.Morada,
                        "NIF do cliente: " + aluguerAtual.Cliente.Nif,
                        "Data de inicio do aluguer: " + aluguerAtual.DataInicio.ToShortDateString(),
                        "Data de fim do aluguer: " + aluguerAtual.DataFim.ToShortDateString(),
                        "Número de quilometros do aluguer: " + aluguerAtual.Kms.ToString(),
                        "Valor do aluguer: " + aluguerAtual.Valor + "€",
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
    }
}
