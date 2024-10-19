using Domain.Services;

namespace Infrastructure.Features
{
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void buttonCreateCustomer_Click(object sender, EventArgs e)
        { 
            CustomerService customerService = new();

            bool response = customerService.CreateCustomer(this.textBoxName.Text, 
                this.textBoxLastName.Text, 
                this.textBoxLimitCredit.Text,
                this.textBoxAddress.Text, 
                this.textBoxCity.Text,
                this.comboBoxProvince.Text,
                this.comboBoxCountry.Text); 

            if (!response) {
                MessageBox.Show("Ocurrio un error al crear el usuario", "Error al crear el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            MessageBox.Show("Usuario creado correctamente", "Usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.textBoxName.Text=string.Empty;
            this.textBoxLastName.Text = string.Empty;
            this.textBoxLimitCredit.Text = string.Empty;
            this.textBoxAddress.Text = string.Empty;
            this.textBoxCity.Text = string.Empty;
            this.comboBoxProvince.SelectedIndex = 0; 
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {
            this.buttonCreateCustomer.Enabled = false; 
            loadCountries();
            loadProvinces();

        }


        private void loadCountries()
        {
            string[] countries = { "Argentina" };

            this.comboBoxCountry.Items.Clear();
            this.comboBoxCountry.Items.AddRange(countries);
            this.comboBoxCountry.SelectedIndex = 0;

        }

        private void loadProvinces()
        {
            string[] provinces = {
                "Buenos Aires", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes",
                "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza",
                "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan", "San Luis",
                "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego",
                "Tucumán"
            };

            this.comboBoxProvince.Items.Clear();
            this.comboBoxProvince.Items.AddRange(provinces);
            this.comboBoxProvince.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            validateFields();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            validateFields();
        }

        private void textBoxLimitCredit_TextChanged(object sender, EventArgs e)
        {
            validateFields();
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            validateFields();
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {

            validateFields();

        }

        private void comboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            validateFields();
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            validateFields();
        }

        /// <summary>
        /// Valida los campos de entrada del formulario de cliente. 
        /// Verifica que los campos de nombre, apellido, límite de crédito, dirección, provincia y país no estén vacíos.
        /// Si algún campo no es válido, el botón de creación de cliente se desactiva.
        /// </summary> 
        private void validateFields()
        {
            if (this.textBoxLastName.Text == "" ||
                this.textBoxName.Text == "" ||
                !int.TryParse(this.textBoxLimitCredit.Text, out int limitCredit) ||
                this.textBoxAddress.Text == "" ||
                this.comboBoxProvince.SelectedIndex == -1 ||
                this.comboBoxCountry.SelectedIndex == -1
               )
            {
                this.buttonCreateCustomer.Enabled = false;
                return;
            }

            this.buttonCreateCustomer.Enabled = true;
        }
    }
}
