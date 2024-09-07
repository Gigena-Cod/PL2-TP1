using _2_varias_columnas_de_datos.Feature.CreateClient;
using _2_varias_columnas_de_datos.Feature.ListClients;
using _2_varias_columnas_de_datos.Features.ListDebtorClients;

namespace _4__Generación_de_informes
{
    public partial class ClientsManagement : Form
    {
        public ClientsManagement()
        {
            InitializeComponent();
        }


        private void nueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateClient createClient = new CreateClient();

            createClient.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListClients listClients = new ListClients();

            listClients.ShowDialog();
        }

        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateClient createClient = new CreateClient();

            createClient.ShowDialog();
        }

        private void verTodosLosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListClients listClients = new ListClients();

            listClients.ShowDialog();
        }

        private void verTodosLosDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDebtorClients listDebtorClients = new ListDebtorClients();

            listDebtorClients.ShowDialog();
        }

        private void ClientsManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
