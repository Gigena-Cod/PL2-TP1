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

        Client[] clients = new Client[100];

        int totalClients = 0;

        private void buttonLoad_Click(object sender, EventArgs e)
        {


            clients[totalClients] = CreateClient();

            ClearAllFields();

            totalClients++;
        }

        private void buttonListClients_Click(object sender, EventArgs e)
        {
            ListClients();
        }

        private Client CreateClient()
        {
            Client client = new Client();

            client.code = Convert.ToInt32(textBoxCode.Text);
            client.name = textBoxName.Text;
            client.debt = Convert.ToDecimal(textBoxDebt.Text);
            client.limitCredit = Convert.ToDecimal(textBoxLimitCredit.Text);

            return client;
        }

        private void ClearAllFields()
        {
            textBoxCode.Text = string.Empty;
            textBoxDebt.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxLimitCredit.Text = string.Empty;
        }

        private void ListClients()
        {
            if (totalClients == 0) return;

            for (int index = 0; index < totalClients; index++)
            {
                dataGridViewClients.Rows.Add(clients[index].code, clients[index].name, clients[index].debt, clients[index].limitCredit);
            }
        }

       
    }
}
