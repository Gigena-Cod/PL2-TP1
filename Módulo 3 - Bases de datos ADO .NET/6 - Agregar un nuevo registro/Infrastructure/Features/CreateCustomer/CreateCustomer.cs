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
            //TODO: Create customer
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {
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
    }
}
