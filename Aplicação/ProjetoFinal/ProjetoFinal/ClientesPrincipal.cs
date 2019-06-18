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

    /*
     if (standDB.Clientes.Where(x => x.Nif.ToString().Contains(textBoxNIF.Text)).Count() == 0)
            {
                resultado = true;
            }
    */

    public partial class ClientesPrincipal : Form
    {
        //Variável do container da database
        oficinaDBContainer standDB;
        //Variável do cliente selecionado atualmente
        Cliente clienteAtual;


        //Código que só é executado após o form ser criado
        public ClientesPrincipal(oficinaDBContainer dBContainer)
        {
            InitializeComponent();
            //Guarda o container da database criado no form main
            standDB = dBContainer;
        }

        //Código que só é executado após o form ser criado, mas antes de ser mostrado
        private void GestaoDeClientesPrincipal_Load(object sender, EventArgs e)
        {
            //Irá mostrar todos os clientes na listbox
            ListarClientes();
        }


        //Código que só é executado após o cliente selecionado na listbox seja mudado
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Código que vai atualizar a listbox dos clientes e atualizar os labels

            if (listBoxClientes.SelectedIndex > -1)
            {
                clienteAtual = (Cliente)listBoxClientes.SelectedItem;

                textBoxNome.Text = clienteAtual.Nome;
                textBoxContacto.Text = clienteAtual.Contacto.ToString();
                textBoxMorada.Text = clienteAtual.Morada;
                textBoxNIF.Text = clienteAtual.Nif.ToString();

                buttonAdicionar.Enabled = false;
            }
            else
            {
                textBoxNome.Clear();
                textBoxContacto.Clear();
                textBoxMorada.Clear();
                textBoxNIF.Clear();
                clienteAtual = null;
                buttonAdicionar.Enabled = true;
            }
        }

        //Código que só é executado após o botão "Adicionar" seja clicado
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            //Código que irá adicionar um carro na database

            string nome;
            int contacto;
            string morada;
            int nif;

            if (AreTextBoxesValid() == true)
            {
                nome = textBoxNome.Text;
                contacto = Int32.Parse(textBoxContacto.Text);
                morada = textBoxMorada.Text;
                nif = Int32.Parse(textBoxNIF.Text);


                Cliente novoCliente = new Cliente(nome, nif, morada, contacto);

                standDB.Clientes.Add(novoCliente);
                standDB.SaveChanges();


                ListarClientes();

            }
            else
            {
                MessageBox.Show("Necessita de ter todas as caixas de texto preenchidas e com valores válidos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Código que só é executado após o botão "Editar" seja clicado
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //Código que irá editar um carro e atualizar a database

            if (AreTextBoxesValid() == true && clienteAtual != null)
            {
                if (Confirmacao("editar", "cliente") == DialogResult.Yes)
                {
                    Cliente clienteASerEditado = clienteAtual;

                    clienteASerEditado.Nome = textBoxNome.Text;
                    clienteASerEditado.Contacto = Int32.Parse(textBoxContacto.Text);
                    clienteASerEditado.Morada = textBoxMorada.Text;
                    clienteASerEditado.Nif = Int32.Parse(textBoxNIF.Text);

                    standDB.SaveChanges();
                    ListarClientes();
                }

            }
            else if (clienteAtual == null)
            {
                MessageBox.Show("Necessita de ter um cliente selecionado para o editar.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Necessita de ter todas as caixas de texto preenchidas e com valores válidos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Código que só é executado após o botão "Eliminar" seja clicado
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //Código que irá eliminar um cliente da database

            if (clienteAtual != null)
            {
                if (clienteAtual.CarrosOficina.Count == 0 && clienteAtual.Vendas.Count == 0 && clienteAtual.Alugueres.Count == 0)
                {
                    if (Confirmacao("eliminar", "cliente") == DialogResult.Yes)
                    {
                        Cliente clienteAEliminar = clienteAtual;
                        standDB.Clientes.Remove(clienteAEliminar);
                        standDB.SaveChanges();
                        ListarClientes();
                    }
                }
                else
                {
                    MessageBox.Show("O cliente atual não pode ser eliminado porque ainda tem informação associada a ele (Carros de Oficina/Vendas/Alugueres).", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Necessita de ter um cliente selecionado para o eliminar.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Código que só é executado se for primida alguma tecla na caixa de texto contacto
        private void textBoxContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //A tecla primida só é aceitada caso seja um numero ou um caracter de controlo (ex: Enter)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        //Código que só é executado se for primida alguma tecla na caixa de texto NIF
        private void textBoxNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            //A tecla primida só é aceitada caso seja um numero ou um caracter de controlo (ex: Enter
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        //Código que verifica se as caixas de texto estão preenchidas e devolve um TRUE or FALSE com a resposta
        private bool AreTextBoxesValid()
        {
            bool resultado = false;
            int i;

            if (textBoxNome.Text != "" && textBoxContacto.Text != "" && textBoxMorada.Text != ""
                && textBoxNIF.Text != "" && int.TryParse(textBoxContacto.Text, out i) && int.TryParse(textBoxNIF.Text, out i))
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
        }

        //Código que faz a confirmação de uma ação devolvendo o restultado dessa ação
        private DialogResult Confirmacao(string funcao = "função", string tipo = "tipo")
        {
            DialogResult result = DialogResult.No;

            result = MessageBox.Show("Tem a certeza que deseja " + funcao + " o(a) seguinte " + tipo + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return result;
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
            //Filtra após cada tecla ser clicada, mas só limpa a caixa de texto se for clicado no ENTER

            if (e.KeyCode == Keys.Enter)
            {
                textBoxFiltrar.Clear();
            }
            Filtrar();
        }
    }
}
