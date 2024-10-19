using _2___Conexión_a_una_base_de_datos.Domain.Services.Customers;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infrastructure.Features
{
    public partial class FindUserByCode : Form
    {
        CustomerServices customerServices = new();

        public FindUserByCode()
        {
            InitializeComponent();
        }

        private void FindUserByCode_Load(object sender, EventArgs e)
        {

        }

        private void buttonFindCustomer_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;

            // Llama al servicio para obtener el cliente por el ID
            Customer? customer = customerServices.GetUserByCode(id);

            // Si el cliente no existe, muestra un mensaje de error y retorna
            if (customer == null)
            {
                MessageBox.Show($"El usuario con ID {id} no existe", "Usuario inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.textBoxFirstName.Text = customer.Name;
            this.textBoxLastName.Text = customer.LastName;
            this.textBoxDebts.Text = customer.Debt.ToString();
        }

    }
}
