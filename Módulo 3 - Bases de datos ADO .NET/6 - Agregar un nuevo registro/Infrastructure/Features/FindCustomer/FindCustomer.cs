using Domain.Models;
using Domain.Services;
using Infrastructure.Utils;
using System.Reflection.Metadata.Ecma335;

namespace Infrastructure.Features
{
    public partial class FindCustomer : Form
    {
        private CustomerService customerService = new(); // Servicio para obtener clientes
        private Customer? customer; // Cliente actual encontrado
        private string state = Constants.FORM_STATE.DEFAULT;

        public FindCustomer()
        {
            InitializeComponent();
        }

        private void ViewCustomers_Load(object sender, EventArgs e)
        {
            loadProvinces();
            this.buttonFindCustomer.Enabled = false;
            this.buttonDeleteCustome.Enabled = false;
            this.buttonUpdateCustomer.Enabled = false;
        }
        private void loadProvinces()
        {
            this.comboBoxProvince.Items.Clear();
            this.comboBoxProvince.Items.AddRange(Constants.PROVINCES);
            this.comboBoxProvince.SelectedIndex = -1;
        }

        private void buttonDeleteCustome_Click(object sender, EventArgs e)
        {
            // Asegurarse de que hay un cliente cargado antes de intentar eliminar
            if (customer == null)
            {
                MessageBox.Show("Por favor, busque un cliente antes de intentar eliminarlo.");
                return;
            }

            // Abre el formulario de confirmación pasando el cliente encontrado
            ConfirmationDeleteCustomer confirmationDeleteCustomer = new ConfirmationDeleteCustomer(customer);

            // Mostrar el diálogo y verificar el resultado
            if (confirmationDeleteCustomer.ShowDialog() == DialogResult.OK)
            {
                // El cliente fue eliminado, así que resetear los datos en el formulario
                ResetFormData();
            }
        }

        private void ResetFormData()
        {
            // Resetea los campos del formulario
            this.textBoxCustomerId.Clear();
            this.textBoxLastName.Clear();
            this.textBoxName.Clear();
            this.textBoxLimitCredt.Clear();
            this.comboBoxProvince.SelectedIndex = -1; // O 0, según lo que necesites
            customer = null; // Limpia la referencia al cliente
        }


        private void buttonFindCustomer_Click(object sender, EventArgs e)
        {
            // Obtiene el ID del cliente desde el TextBox
            string customerId = this.textBoxCustomerId.Text;


            // Busca el cliente por ID
            Customer? findCustomer = customerService.GetCustomerById(customerId);

            // Si no se encuentra el cliente, muestra un mensaje
            if (findCustomer == null)
            {
                this.textBoxLastName.Text = string.Empty;
                this.textBoxName.Text = string.Empty;
                this.textBoxLimitCredt.Text = string.Empty;
                this.buttonUpdateCustomer.Enabled = false;
                this.buttonDeleteCustome.Enabled = false;
                this.comboBoxProvince.SelectedIndex = -1;
                MessageBox.Show("El cliente no existe");
                return;
            }

            // Si el cliente se encuentra, se actualiza la referencia local al cliente
            customer = findCustomer;

            this.textBoxLastName.Text = customer.LastName;
            this.textBoxName.Text = customer.Name;
            this.textBoxLimitCredt.Text = customer.LimitCredit.ToString();
            this.buttonUpdateCustomer.Enabled = true;
            this.buttonDeleteCustome.Enabled = true;

            // Obtener el índice de la provincia
            int provinceIndex = Array.IndexOf(Constants.PROVINCES, customer.Province);

            // Verificar si la provincia existe en el array
            if (provinceIndex >= 0)
            {
                this.comboBoxProvince.SelectedIndex = provinceIndex; // Asigna el índice al ComboBox
            }
            else
            {
                MessageBox.Show("La provincia del cliente no se encontró.");
            }


        }

        private void textBoxCustomerId_TextChanged(object sender, EventArgs e)
        {
            validateFields();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {

            if (!this.buttonDeleteCustome.Enabled)
            {

                this.buttonDeleteCustome.Enabled = true;
                this.buttonUpdateCustomer.Text = "Modificar";
                this.textBoxName.Enabled = false;
                this.textBoxLastName.Enabled = false;
                this.textBoxLimitCredt.Enabled = false;
                this.comboBoxProvince.Enabled = false;

                int provinceIndex = Array.IndexOf(Constants.PROVINCES, this.comboBoxProvince.Text) + 1;

                bool isUpdated = customerService.UpdateCustomer(customer.Id, this.textBoxName.Text, this.textBoxLastName.Text, Convert.ToInt32(this.textBoxLimitCredt.Text), provinceIndex);

                if (!isUpdated)
                {
                    MessageBox.Show("Error al actualizat el cliente");
                }
                return;
            }


            this.buttonDeleteCustome.Enabled = false;
            this.buttonUpdateCustomer.Text = "Guardar cambios";
            this.textBoxName.Enabled = true;
            this.textBoxLastName.Enabled = true;
            this.textBoxLimitCredt.Enabled = true;
            this.comboBoxProvince.Enabled = true;
        }

        private void validateFields()
        {
            string customerId = this.textBoxCustomerId.Text;

            if (string.IsNullOrEmpty(customerId))
            {
                this.buttonFindCustomer.Enabled = false;

            }

            this.buttonFindCustomer.Enabled = true;

        }
    }
}
