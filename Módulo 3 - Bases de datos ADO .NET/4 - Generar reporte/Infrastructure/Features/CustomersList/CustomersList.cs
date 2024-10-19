
using _2___Conexión_a_una_base_de_datos.Domain.Services.Customers;
using Domain;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace Infrastructure.Features
{
    public partial class CustomersList : Form
    {
        CustomerServices customerServices = new();
        public CustomersList()
        {
            InitializeComponent();
        }

        private void CustomersList_Load(object sender, EventArgs e)
        {
            dataGridViewCustomers.Rows.Clear();


            this.labelTotalCustomers.Text = "Cargando";
            this.labelAverageDebts.Text = "";
            this.labelTotalDebts.Text = "";

            ResponseGetAllCustomers? response = customerServices.GetAllUsers();

            if (response.Customers == null || response.Customers.Count == 0) return;

            foreach (Customer customerItem in response.Customers)
            {

                dataGridViewCustomers.Rows.Add(customerItem.Id, customerItem.Name, customerItem.LastName, customerItem.Email, customerItem.Debt.ToString("C"));
            }

            this.labelTotalCustomers.Text = $"{response.TotalCustomer} resultados";
            this.labelAverageDebts.Text = response.AverageDebts.ToString("C");
            this.labelTotalDebts.Text = response.TotalDebts.ToString("C");

        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            ResponseGetAllCustomers responseGetAllCustomers = customerServices.GetAllUsers();

           

          
        }

        private void GenerateReport(List<Customer> customers,string totalDebts, string totalCustomer, string averageDebts)
        {
            using (StreamWriter streamWriter = new("Reporte.csv", false))
            {
                streamWriter.WriteLine("Reporte - 2024");
                streamWriter.WriteLine("");
                streamWriter.WriteLine($"Cantidad de Usuarios;{totalCustomer}");
                streamWriter.WriteLine("");
                streamWriter.WriteLine("Id;Name;LastName;Email;Debt");


                foreach (Customer customer in customers)
                {
                    streamWriter.WriteLine($"{customer.Id};{customer.Name};{customer.LastName};{customer.Email};{customer.Debt}");

                }


                streamWriter.WriteLine("");

                streamWriter.WriteLine($"Deuda total;{totalDebts}");
                streamWriter.WriteLine($"Promedio de deuda;{averageDebts}");

                MessageBox.Show("Reporte generado con exito", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
