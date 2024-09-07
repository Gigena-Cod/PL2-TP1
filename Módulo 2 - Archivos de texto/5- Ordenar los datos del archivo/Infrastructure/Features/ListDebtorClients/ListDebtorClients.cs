using Domain.Models;
using Domain.Services;

namespace Features
{
    public partial class ListDebtorClients : Form
    {
        public ListDebtorClients()
        {
            InitializeComponent();
        }

        ClientsService service = new();

        private void button1_Click(object sender, EventArgs e)
        {
            service.PostReportDebtorClients();

            MessageBox.Show("Reporte generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListDebtorClients_Load(object sender, EventArgs e)
        {
            dataGridViewClients.Rows.Clear();

            var (clients, totalClients, totalDebt, averageDebt) = service.getDebtorClients();


            foreach (Client client in clients)
            {
                dataGridViewClients.Rows.Add(client.Code, client.FullName, client.Debt.ToString("C"), client.CreditLimit.ToString("C"));
            }

            textBoxDebts.Text = totalDebt.ToString("C");

            textBoxTotalClientes.Text = totalClients.ToString();

            textBoxAverage.Text = averageDebt.ToString("C");
        }
    }
}
