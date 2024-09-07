using Features;

namespace Features
{
    public partial class ClientsManagement : Form
    {
        public ClientsManagement()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateClient createClient = new();
            createClient.ShowDialog();
        }

        private void verTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListClients listClients = new();
            listClients.ShowDialog();
        }

        private void verTofdosLosClientesDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: List all client debtor
        }
    }
}
