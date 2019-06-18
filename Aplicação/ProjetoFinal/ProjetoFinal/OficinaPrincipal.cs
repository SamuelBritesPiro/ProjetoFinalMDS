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
    public partial class OficinaPrincipal : Form
    {
        //Variável do container da database
        oficinaDBContainer standDB;
        //Variável do cliente selecionado atualmente
        Cliente clienteAtual;
        //Variável do carro de oficina selecionado atualmente
        CarroOficina carroOficinaAtual;
        //Variável do serviço selecionado atualmente
        Servico servicoAtual;
        //Variável da parcela selecionado atualmente
        Parcela parcelaAtual;

        //Código que só é executado após o form ser criado
        public OficinaPrincipal(oficinaDBContainer dBContainer)
        {
            InitializeComponent();
            //Guarda o container da database criado no form main
            standDB = dBContainer;
        }

        //Código que só é executado após o form ser criado, mas antes de ser mostrado
        private void GestaoDeOficinaPrincipal_Load(object sender, EventArgs e)
        {
            ListarClientes();
            ListarCarrosOficina();
        }

        //Código que só é executado após o botão "Filtrar por Nome" seja clicado
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            //Filtra por nome de acordo com o está colocado na caixa de texto 
            Filtrar();
            textBoxFiltrar.Clear();
        }


        //Código que atualiza a listbox dos clientes
        private void ListarClientes()
        {
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = standDB.Clientes.ToList();
            listBoxClientes.SelectedIndex = -1;
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
            ListarCarrosOficina();
        }

        //Código que só é executado após o cliente selecionado na listbox seja mudado
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Código que vai atualizar a listbox dos clientes e atualizar os labels
            if (listBoxClientes.SelectedIndex > -1)
            {
                clienteAtual = (Cliente)listBoxClientes.SelectedItem;
                labelNomeCliente.Text = clienteAtual.Nome;
                labelNumeroCliente.Text = clienteAtual.Contacto.ToString();
                labelMoradaCliente.Text = clienteAtual.Morada;
                labelValorTotal.Text = clienteAtual.TotalCarrosOficina().ToString();
                ListarCarrosOficina();
            }
            else
            {
                clienteAtual = null;
                labelNomeCliente.Text = "Nenhum cliente selecionado";
                labelNumeroCliente.Text = "-";
                labelMoradaCliente.Text = "-";
                labelValorTotal.Text = "0";
                listBoxCarrosOficina.SelectedIndex = -1;

            }
        }

        //Código que só é executado após o botão "Gerir carro de oficina" seja clicado
        private void buttonGerirCarroDeOficina_Click(object sender, EventArgs e)
        {
            //Código que irá abrir o form da gestão do carro de oficina
            if (clienteAtual != null && carroOficinaAtual != null)
            {
                OficinaCarrosGestao oficinaGestaoCarros = new OficinaCarrosGestao(standDB, clienteAtual, carroOficinaAtual);
                oficinaGestaoCarros.ShowDialog();
                ListarCarrosOficina();
            }
            else
            {
                MessageBox.Show("Necessita de ter um cliente e um carro de oficina selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //Código que só é executado após o botão "Adicionar carro de oficina" seja clicado
        private void buttonAdicionarCarro_Click(object sender, EventArgs e)
        {
            //Código que irá abrir o form de adicionar carro de oficina

            if (clienteAtual != null)
            {
                OficinaCarrosAdicionar oficinaCarrosAdicionar = new OficinaCarrosAdicionar(standDB, clienteAtual);
                oficinaCarrosAdicionar.ShowDialog();
                ListarCarrosOficina();
            }
            else
            {
                MessageBox.Show("Necessita de ter um cliente selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Código que atualiza a listbox dos carros de oficina
        private void ListarCarrosOficina()
        {
            listBoxCarrosOficina.DataSource = null;

            if (clienteAtual != null)
            {
                listBoxCarrosOficina.DataSource = clienteAtual.CarrosOficina.ToList();
                labelValorTotal.Text = clienteAtual.TotalCarrosOficina().ToString();

            }

            listBoxCarrosOficina.SelectedIndex = -1;
            carroOficinaAtual = null;

        }

        //Código que só é executado após o carro de oficina selecionado na listbox seja mudado
        private void listBoxCarrosOficina_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Código que irá listar os carros de oficina e serviços

            carroOficinaAtual = null;
            listBoxServicos.SelectedIndex = -1;
            if (listBoxCarrosOficina.SelectedIndex > -1)
            {
                carroOficinaAtual = (CarroOficina)listBoxCarrosOficina.SelectedItem;

            }
            ListarServicos();

        }

        //Código que só é executado após o botão "Adicionar serviço" seja clicado
        private void buttonAdicionarServico_Click(object sender, EventArgs e)
        {
            //Código que irá abrir o form de adicionar serviços

            if (clienteAtual != null && carroOficinaAtual != null)
            {
                OficinaServicoAdicionar oficinaServicoAdicionar = new OficinaServicoAdicionar(standDB, clienteAtual, carroOficinaAtual);
                oficinaServicoAdicionar.ShowDialog();
                ListarServicos();
            }
            else
            {
                MessageBox.Show("Necessita de ter um cliente e um carro de oficina selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Código que atualiza a listbox dos serviços
        private void ListarServicos()
        {
            //Código que irá listar os serviços

            listBoxServicos.DataSource = null;

            if (carroOficinaAtual != null)
            {
                labelValorTotal.Text = clienteAtual.TotalCarrosOficina().ToString();
                listBoxServicos.DataSource = carroOficinaAtual.Servicos.ToList();
            }

            listBoxServicos.SelectedIndex = -1;
            servicoAtual = null;

        }

        //Código que só é executado após o serviços selecionado na listbox seja mudado
        private void listBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Código que irá listar os carros de serviços e parcelas


            if (listBoxServicos.SelectedIndex > -1)
            {
                servicoAtual = (Servico)listBoxServicos.SelectedItem;
            }
            else
            {
                servicoAtual = null;
                listBoxParcelas.SelectedIndex = -1;
            }

            ListarParcelas();
        }

        //Código que só é executado após o botão "Gerir Serviço" seja clicado
        private void buttonServico_Click(object sender, EventArgs e)
        {
            //Código que irá abrir o form de gerir os serviços

            if (clienteAtual != null && carroOficinaAtual != null && servicoAtual != null)
            {
                OficinaServicoGestao oficinaServicoGestao = new OficinaServicoGestao(standDB, clienteAtual, carroOficinaAtual, servicoAtual);
                oficinaServicoGestao.ShowDialog();
                ListarServicos();
            }
            else
            {
                MessageBox.Show("Necessita de ter um cliente, um carro de oficina e um serviço selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Código que só é executado após o botão "Adicionar Parcela" seja clicado
        private void buttonAdicionarParcela_Click(object sender, EventArgs e)
        {
            //Código que irá abrir o form de adicionar parcelas

            if (clienteAtual != null && carroOficinaAtual != null && servicoAtual != null)
            {
                OficinaParcelaAdicionar oficinaParcelaAdicionar = new OficinaParcelaAdicionar(standDB, clienteAtual, carroOficinaAtual, servicoAtual);
                oficinaParcelaAdicionar.ShowDialog();
                ListarParcelas();
            }
            else
            {
                MessageBox.Show("Necessita de ter um cliente, carro de oficina e um serviço selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Código que atualiza a listbox das parcelas
        private void ListarParcelas()
        {
            listBoxParcelas.DataSource = null;

            if (servicoAtual != null)
            {
                listBoxParcelas.DataSource = servicoAtual.Parcelas.ToList();
                labelValorTotal.Text = clienteAtual.TotalCarrosOficina().ToString();

            }

            listBoxParcelas.SelectedIndex = -1;
            parcelaAtual = null;



        }
        //Código que só é executado após a parcela selecionada na listbox seja mudada
        private void listBoxParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Código que irá listar as parcelas

            if (listBoxParcelas.SelectedIndex > -1)
            {
                parcelaAtual = (Parcela)listBoxParcelas.SelectedItem;
            }
            else
            {
                parcelaAtual = null;
            }
        }

        //Código que só é executado após o botão "Gerir Parcela" seja clicado
        private void buttonGerirParcela_Click(object sender, EventArgs e)
        {
            //Código que irá abrir o form de gerir parcelas

            if (clienteAtual != null && carroOficinaAtual != null && servicoAtual != null && parcelaAtual != null)
            {
                OficinaParcelaGestao oficinaParcelaGestao = new OficinaParcelaGestao(standDB, clienteAtual, carroOficinaAtual, servicoAtual, parcelaAtual);
                oficinaParcelaGestao.ShowDialog();
                ListarParcelas();
            }
            else
            {
                MessageBox.Show("Necessita de ter um cliente, um carro de oficina, um serviço e uma parcela selecionada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //Código que irá escrever num ficheiro o recibo do serviço da oficina selecionado
            if (servicoAtual != null)
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

                    string[] text = null;

                    List<string> lista = new List<string>
                    {
                        "Recibo:",
                        "Nome do cliente: " + servicoAtual.CarroOficina.Cliente.Nome,
                        "Morada do cliente: " + servicoAtual.CarroOficina.Cliente.Morada,
                        "NIF do cliente: " + servicoAtual.CarroOficina.Cliente.Nif,
                        "Data de entrada : " + servicoAtual.DataEntrada.ToShortDateString(),
                        "Tipo de serviço: " + servicoAtual.Tipo,
                        "Data de saída: " + servicoAtual.DataSaida.ToShortDateString()
                    };

                    foreach (Parcela item in servicoAtual.Parcelas)
                    {
                        lista.Add("Descrição: " + item.Descricao + " (" + item.Valor + ")");
                    }



                    text = lista.ToArray();

                    using (StreamWriter outputFile = new StreamWriter(fileLocation))
                    {
                        foreach (string line in text)
                            outputFile.WriteLine(line);
                    }
                }
            }
            else
            {
                MessageBox.Show("Necessita de ter um serviço selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
