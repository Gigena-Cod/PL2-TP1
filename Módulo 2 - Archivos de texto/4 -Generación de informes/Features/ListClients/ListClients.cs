using Domain.Models;
using Domain.Services;

namespace _2_varias_columnas_de_datos.Feature.ListClients
{
    public partial class ListClients : Form
    {
        public ListClients()
        {
            InitializeComponent();
        }

        ClientsService clientService = new();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dataGridViewClients.Rows.Clear();

            var (clients, totalClients, totalDebt, averageDebt) = clientService.getClients();


            foreach (Client client in clients)
            {
                dataGridViewClients.Rows.Add(client.Code, client.FullName, client.Debt.ToString("C"), client.CreditLimit.ToString("C"));
            }

            textBoxDebts.Text = totalDebt.ToString("C");

            textBoxTotalClientes.Text = totalClients.ToString();

            textBoxAverage.Text = averageDebt.ToString("C");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientService.PostReportClients();

            MessageBox.Show("Reporte generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
