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

        const int MAXIMUN_CLIENTS = 20;

        Client[] clients = new Client[MAXIMUN_CLIENTS];

        int totalClients = 0;

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string code = textBoxCode.Text.ToUpper();

            bool exist = validateExistCode(code);

            if (exist)
            {
                MessageBox.Show(
                    "El código ingresado ya existe en el sistema. Por favor, ingrese un código diferente.",
                    "Código Duplicado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                textBoxCode.Text = string.Empty;
                return;
            }

            clients[totalClients] = createClient();

            clearAllFields();

            totalClients++;

            listClients();

            calculateDebts();

            MessageBox.Show("El cliente se cargó correctamente.", "Carga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            if (totalClients >= MAXIMUN_CLIENTS)
            {
                MessageBox.Show(
                    "No se pueden agregar más clientes, se ha alcanzado el límite.",
                    "Límite Alcanzado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
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
            loadMockClients();
            listClients();
            calculateDebts();
        }

        private Client createClient()
        {
            Client client = new Client();

           
            client.code = textBoxCode.Text.ToUpper();
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

        private void loadMockClients()
        {
            clients[0] = new Client { code = "C001", name = "John Doe", debt = 1000.0m, limitCredit = 5000.0m };
            clients[1] = new Client { code = "C002", name = "Jane Smith", debt = 250.0m, limitCredit = 2000.0m };
            clients[2] = new Client { code = "C003", name = "Michael Brown", debt = 1500.0m, limitCredit = 7000.0m };
            clients[3] = new Client { code = "C004", name = "Emily Davis", debt = 300.0m, limitCredit = 1500.0m };
            clients[4] = new Client { code = "C005", name = "David Wilson", debt = 800.0m, limitCredit = 4000.0m };
            clients[5] = new Client { code = "C006", name = "Sarah Miller", debt = 450.0m, limitCredit = 3500.0m };
            clients[6] = new Client { code = "C007", name = "Chris Evans", debt = 1200.0m, limitCredit = 6000.0m };
            clients[7] = new Client { code = "C008", name = "Laura Johnson", debt = 500.0m, limitCredit = 2500.0m };
            clients[8] = new Client { code = "C009", name = "Kevin Anderson", debt = 900.0m, limitCredit = 4500.0m };
            clients[9] = new Client { code = "C010", name = "Lisa Thompson", debt = 200.0m, limitCredit = 1000.0m };
            totalClients = 10;
        }

        private bool validateExistCode(string code)
        {
            for (int i = 0; i < totalClients; i++)
            {
                if (clients[i].code == code)
                {
                    return true; // Si el código se encuentra, retorna inmediatamente
                }
            }
            return false; // Si no se encuentra, retorna false
        }


    }
}
