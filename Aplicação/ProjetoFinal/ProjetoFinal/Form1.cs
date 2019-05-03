using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ProjetoFinal
{
    public partial class Form1 : Form
    {
        oficinaDBContainer standDB;


        public Form1()
        {
            InitializeComponent();

            standDB = new oficinaDBContainer();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cliente novoCliente = new Cliente("nome", 123, "morada", 456);
            //MessageBox.Show(novoCliente.Nome + " " + novoCliente.Nif + " " + novoCliente.Morada + " " + novoCliente.Contacto, "teste", MessageBoxButtons.OK, MessageBoxIcon.Information);

            standDB.Clientes.Add(novoCliente);
            standDB.SaveChanges();


            MessageBox.Show(standDB.Clientes.ToList().ToString());



            Listar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = standDB.Clientes.ToList();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clipboard.SetText(listBox1.SelectedItem.ToString());
        }
    }
}
