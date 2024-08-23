namespace _3___Vectores_constituidos_por_registros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private struct Client
        {
            public int code;
            public string name;
            public decimal debt;
            public decimal limitCredit;
        }

        Client[] clients = new Client[1000];

        int totalClients = 0;

        private void buttonLoad_Click(object sender, EventArgs e)
        {


            clients[totalClients] = createClient();

            clearAllFields();

            totalClients++;

            MessageBox.Show("El cliente se cargó correctamente.", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonListClients_Click(object sender, EventArgs e)
        {
            listClients();
        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {
            validateFields();
        }

        private void textBoxDebt_TextChanged(object sender, EventArgs e)
        {
            validateFields();
        }

        private void textBoxLimitCredit_TextChanged(object sender, EventArgs e)
        {
            validateFields();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            validateFields();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonLoad.Enabled = false;
        }

        private Client createClient()
        {
            Client client = new Client();

            client.code = Convert.ToInt32(textBoxCode.Text);
            client.name = textBoxName.Text;
            client.debt = Convert.ToDecimal(textBoxDebt.Text);
            client.limitCredit = Convert.ToDecimal(textBoxLimitCredit.Text);       

            return client;
        }

        private void clearAllFields()
        {
            textBoxCode.Text = string.Empty;
            textBoxDebt.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxLimitCredit.Text = string.Empty;
            buttonLoad.Enabled = false;
        }

        private void listClients()
        {
            dataGridViewClients.Rows.Clear();

            if (totalClients == 0) return;

            for (int index = 0; index < totalClients; index++)
            {
                dataGridViewClients.Rows.Add(clients[index].code, clients[index].name, clients[index].debt, clients[index].limitCredit);
            }
        }

        private void validateFields()
        {
            if (totalClients == 1000)
            {
                buttonLoad.Enabled = false;
                return;
            }

            if (string.IsNullOrEmpty(textBoxCode.Text) ||
                string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxDebt.Text) ||
                string.IsNullOrEmpty(textBoxLimitCredit.Text))
            {
                buttonLoad.Enabled = false;
                return;
            }

            if (!int.TryParse(textBoxCode.Text, out _) ||
                !decimal.TryParse(textBoxDebt.Text, out _) ||
                !decimal.TryParse(textBoxLimitCredit.Text, out _))
            {
                buttonLoad.Enabled = false;
                return;
            }

            buttonLoad.Enabled = true;


        }

        
    }
}
