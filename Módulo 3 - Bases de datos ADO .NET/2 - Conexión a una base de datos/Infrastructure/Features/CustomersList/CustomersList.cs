
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
            List<Customer> customer = customerServices.GetAllUsers();

            foreach (Customer customerItem in customer) {

                dataGridViewCustomers.Rows.Add(customerItem.Id, customerItem.Name, customerItem.LastName, customerItem.Email);
            }
        }
    }
}
