namespace Infrastructure.Features
{
    public partial class CustomerManagement : Form
    {
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe aboutMe = new();

            aboutMe.ShowDialog();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersList customersList = new CustomersList();
            customersList.ShowDialog();
        }
    }
}
