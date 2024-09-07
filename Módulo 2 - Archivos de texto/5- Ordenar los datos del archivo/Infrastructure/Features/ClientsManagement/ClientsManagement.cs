using Features;

namespace _5__Ordenar_los_datos_del_archivo
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
            //TODO:Open popup create Cliente
            CreateClient createClient = new();
            createClient.ShowDialog();
        }

        private void verTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: List all client
        }

        private void verTofdosLosClientesDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: List all client debtor
        }
    }
}
