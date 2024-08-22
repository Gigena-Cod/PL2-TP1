namespace Dos_Vectores
{
    public partial class expenseManager : Form
    {
        public expenseManager()
        {
            InitializeComponent();
        }

        String[] months = new String[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        Decimal[] amounts = new Decimal[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private void expenseManager_Load(object sender, EventArgs e)
        {
            comboBoxAmount.Items.Clear();

            foreach (string month in months)
            {
                comboBoxAmount.Items.Add(month);
            }

            comboBoxAmount.SelectedIndex = 0;

        }
    }
}
