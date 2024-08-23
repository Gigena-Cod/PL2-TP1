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
            public string code;
            public string name;
            public decimal debt;
            public decimal limitCredit;
        }

        const int MAXIMUN_CLIENTS = 2;

        Client[] clients = new Client[MAXIMUN_CLIENTS];

        int totalClients = 0;

        private void buttonLoad_Click(object sender, EventArgs e)
        {


            clients[totalClients] = createClient();

            clearAllFields();

            totalClients++;

            listClients();

            calculateDebts();

            MessageBox.Show("El cliente se cargó correctamente.", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (totalClients < MAXIMUN_CLIENTS) return;

            MessageBox.Show("No se pueden agregar más clientes, se ha alcanzado el límite.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            labelTotalDebts.Text = Convert.ToString(0);
        }

        private Client createClient()
        {
            Client client = new Client();

            client.code = textBoxCode.Text;
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

        private void calculateDebts()
        { 
            if (totalClients == 0)
            {
                labelTotalDebts.Text = "0";
                return;
            }
             
            decimal totalDebt = 0;
             
            for (int index = 0; index < totalClients; index++)
            {
                totalDebt += clients[index].debt;
            }
             
            labelTotalDebts.Text = totalDebt.ToString("C");
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
            if (totalClients == MAXIMUN_CLIENTS)
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

            if (!decimal.TryParse(textBoxDebt.Text, out _) ||
                !decimal.TryParse(textBoxLimitCredit.Text, out _))
            {
                buttonLoad.Enabled = false;
                return;
            }

            buttonLoad.Enabled = true;


        }

        
    }
}
