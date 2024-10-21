
using Domain.Models;
using Domain.Services;

namespace Infrastructure.Features
{
    public partial class ConfirmationDeleteCustomer : Form
    {
        private readonly string deleteCustomerId;
        private CustomerService customerService = new();

        public ConfirmationDeleteCustomer(Customer customer)
        {
            InitializeComponent();
            deleteCustomerId = customer.Id.ToString();
            this.labelDescription.Text = $"Estás a punto de eliminar al usuario '{customer.Name} {customer.LastName}'." +
                $" Esta acción es irreversible y no podrás realizar más cambios. ¿Deseas continuar?";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ConfirmationDeleteCustomer_Load(object sender, EventArgs e)
        {

        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
          
            bool isDeleted = customerService.DeleteCustomer(deleteCustomerId); // Llama al servicio para eliminar

            if (isDeleted)
            { 
                this.DialogResult = DialogResult.OK; // Indica que se eliminó con éxito
            }
            else
            {
                MessageBox.Show("Error al eliminar el cliente.");
                this.DialogResult = DialogResult.Cancel; // Indica que no se eliminó
            }

            this.Close();  
        }
    }
}
