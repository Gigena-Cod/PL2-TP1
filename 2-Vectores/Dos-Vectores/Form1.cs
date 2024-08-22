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

            for (int index = 0; index < 12; index++)
            {
                dataGridViewExpenses.Rows.Add(months[index],amounts[index]);
            }

        }

        private void saveAmount_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado un mes
            if (comboBoxAmount.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un mes de la lista.", "Selección de mes requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica si se ha ingresado un monto válido
            if (string.IsNullOrEmpty(textBoxAmount.Text) || !int.TryParse(textBoxAmount.Text, out int amount) || amount <= 0)
            {
                MessageBox.Show("Por favor, ingresa un monto válido mayor a cero.", "Monto inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            amounts[comboBoxAmount.SelectedIndex] += amount;

            textBoxAmount.Clear();

            MessageBox.Show("El monto ha sido guardado exitosamente.", "Monto guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
