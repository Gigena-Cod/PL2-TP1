using _2_varias_columnas_de_datos.Feature.CreateClient;
using _2_varias_columnas_de_datos.Feature.ListClients;

namespace _2_varias_columnas_de_datos
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
    }
}
