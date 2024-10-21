
using Domain.Services;
using Domain.Models;

namespace Infrastructure.Features
{
    public partial class ViewCustomers : Form
    {
        CustomerService customerService = new();

        public ViewCustomers()
        {
            InitializeComponent();
        }

        private void ViewCustomers_Load(object sender, EventArgs e)
        {
            dataGridViewCustomers.Rows.Clear();

            List<Customer>? customers = customerService.GetAllCustomers();

            if (customers == null) return;

            foreach (Customer customer in customers)
            {
                dataGridViewCustomers.Rows.Add(customer.Id, customer.Name, customer.LastName, customer.Debts, customer.LimitCredit, customer.Province);
            }

            this.labelCountCustomers.Text = $"{customers.Count.ToString()} resultados";
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            List<Customer>? customers = customerService.GetAllCustomers();

            GenerateCustomerReport(customers);
        }

        private void GenerateCustomerReport(List<Customer>? customers)
        {
            if (customers == null || customers.Count == 0)
            {
                MessageBox.Show("No existen usuarios para generar el reporte", "Reporte");
                return;
            }

            using (StreamWriter streamWriter = new("ReporteClientes.csv", false)) // Asegúrate de incluir una extensión de archivo
            {
                streamWriter.WriteLine("Reporte de clientes");
                streamWriter.WriteLine("");
                streamWriter.WriteLine($"{customers.Count} resultados");
                streamWriter.WriteLine("");
                streamWriter.WriteLine($"ID;Nombre;Apellido;Deuda;Limite crediticio;Provincia");

                foreach (Customer customer in customers)
                {
                    streamWriter.WriteLine($"{customer.Id};{customer.Name};{customer.LastName};{customer.Debts};{customer.LimitCredit};{customer.Province}");
                }
            }

            MessageBox.Show("Reporte generado exitosamente", "Reporte");
        }

    }
}
