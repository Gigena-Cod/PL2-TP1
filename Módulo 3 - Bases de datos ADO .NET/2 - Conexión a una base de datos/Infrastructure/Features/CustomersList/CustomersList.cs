
using _2___Conexión_a_una_base_de_datos.Domain.Services.Customers;
using Domain;
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

                dataGridViewCustomers.Rows.Add(customerItem.Id, customerItem.Name, customerItem.LastName, customerItem.Email , customerItem.Debt.ToString("C"));
            }

            this.labelTotalCustomers.Text = $"{response.TotalCustomer} resultados";
            this.labelAverageDebts.Text = response.AverageDebts.ToString("C");
            this.labelTotalDebts.Text = response.TotalDebts.ToString("C");

        }

    }
}
