using _4__Listados_condicionados_y_búsqueda_de_datos;

namespace _3___Vectores_constituidos_por_registros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
               

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

            Globals.clients[Globals.totalClients] = createClient();

            clearAllFields();

            Globals.totalClients++;

            listClients();

            calculateDebts();

            MessageBox.Show("El cliente se cargó correctamente.", "Carga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (Globals.totalClients >= Globals.MAXIMUN_CLIENTS)
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

        private Globals.Client createClient()
        {
            Globals.Client client = new Globals.Client();


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
           if( Globals.totalClients == 0)
            {
                labelTotalDebts.Text = "0";
                return;
            }

            decimal totalDebt = 0;

            for (int index = 0; index < Globals.totalClients; index++)
            {
                totalDebt += Globals.clients[index].debt;
            }

            labelTotalDebts.Text = totalDebt.ToString("C");
        }


        private void listClients()
        {
            dataGridViewClients.Rows.Clear();

            if (Globals.totalClients == 0) return;

            for (int index = 0; index < Globals.totalClients; index++)
            {
                dataGridViewClients.Rows.Add(Globals.clients[index].code, Globals.clients[index].name, Globals.clients[index].debt, Globals.clients[index].limitCredit);
            }
        }

        private void validateFields()
        {
            if (Globals.totalClients == Globals.MAXIMUN_CLIENTS)
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
            Globals.clients[0] = new Globals.Client { code = "C001", name = "John Doe", debt = 1000.0m, limitCredit = 5000.0m };
            Globals.clients[1] = new Globals.Client { code = "C002", name = "Jane Smith", debt = 0m, limitCredit = 2000.0m };
            Globals.clients[2] = new Globals.Client { code = "C003", name = "Michael Brown", debt = 1500.0m, limitCredit = 7000.0m };
            Globals.clients[3] = new Globals.Client { code = "C004", name = "Emily Davis", debt = 300.0m, limitCredit = 1500.0m };
            Globals.clients[4] = new Globals.Client { code = "C005", name = "David Wilson", debt = 800.0m, limitCredit = 4000.0m };
            Globals.clients[5] = new Globals.Client { code = "C006", name = "Sarah Miller", debt = 0m, limitCredit = 3500.0m };
            Globals.clients[6] = new Globals.Client { code = "C007", name = "Chris Evans", debt = 1200.0m, limitCredit = 6000.0m };
            Globals.clients[7] = new Globals.Client { code = "C008", name = "Laura Johnson", debt = 500.0m, limitCredit = 2500.0m };
            Globals.clients[8] = new Globals.Client { code = "C009", name = "Kevin Anderson", debt = 0m, limitCredit = 4500.0m };
            Globals.clients[9] = new Globals.Client { code = "C010", name = "Lisa Thompson", debt = 200.0m, limitCredit = 1000.0m };
            Globals.totalClients = 10;
        }

        private bool validateExistCode(string code)
        {
            for (int i = 0; i < Globals.totalClients; i++)
            {
                if (Globals.clients[i].code == code)
                {
                    return true; // Si el código se encuentra, retorna inmediatamente
                }
            }
            return false; // Si no se encuentra, retorna false
        }

        private void buttonListDebts_Click(object sender, EventArgs e)
        {
            listDebts();

        }

        private void listDebts()
        {
            dataGridViewClients.Rows.Clear();

            for (int index = 0; index < Globals.totalClients; index++)
            {
                if (Globals.clients[index].debt == 0) continue;

                dataGridViewClients.Rows.Add(Globals.clients[index].code, Globals.clients[index].name, Globals.clients[index].debt, Globals.clients[index].limitCredit);

            }

            calculateDebts();
        }

        private void buttonListClients_Click(object sender, EventArgs e)
        {
            listClients();
        }
    }
}
