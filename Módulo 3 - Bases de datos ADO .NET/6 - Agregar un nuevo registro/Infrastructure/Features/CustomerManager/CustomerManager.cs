namespace Infrastructure.Features
{
    public partial class CustomerManager : Form
    {
        public CustomerManager()
        {
            InitializeComponent();
        }

        private void CustomerManager_Load(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCustomer createCustomer = new CreateCustomer();

            createCustomer.ShowDialog();

        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindCustomer findCustomer = new FindCustomer();
            findCustomer.ShowDialog();
        }
    }
}
