using System;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Main : Form
    {

        //Variável do container da database
        oficinaDBContainer standDB;

        public Main()
        {
            InitializeComponent();

            //Cria uma nova instância da database container
            standDB = new oficinaDBContainer();
        }

        //Codigo que só será executado ao clicar no botão de Gestão de Clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            /*Cria uma nova instância do form de gestão de clientes, enviando a instância da database criada
             *e abre o form criado.
            */
            ClientesPrincipal gestaoDeClientesPrincipal = new ClientesPrincipal(standDB);
            gestaoDeClientesPrincipal.ShowDialog();
        }

        //Codigo que só será executado ao clicar no botão de Gestão de Oficina
        private void btnOficina_Click(object sender, EventArgs e)
        {
            /*Cria uma nova instância do form de gestão de oficina, enviando a instância da database criada
             * e abre o form criado.
            */
            OficinaPrincipal gestaoDeOficinaPrincipal = new OficinaPrincipal(standDB);
            gestaoDeOficinaPrincipal.ShowDialog();
        }

        //Codigo que só será executado ao clicar no botão de Gestão de Alugueres
        private void btnAluguer_Click(object sender, EventArgs e)
        {
            /*Cria uma nova instância do form de gestão de alugueres, enviando a instância da database criada
             * e abre o form criado.
            */
            AlugueresPrincipal alugueresPrincipal = new AlugueresPrincipal(standDB);
            alugueresPrincipal.ShowDialog();
        }

        //Codigo que só será executado ao clicar no botão de Gestão de Vendas
        private void btnVendas_Click(object sender, EventArgs e)
        {
            /*Cria uma nova instância do form de gestão de vendas, enviando a instância da database criada
             * e abre o form criado.
            */
            VendasPrincipal vendasPrincipal = new VendasPrincipal(standDB);
            vendasPrincipal.ShowDialog();
        }

    }
}
