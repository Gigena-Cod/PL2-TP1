using Domain.Adapters;
using Domain.Models;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_varias_columnas_de_datos.Feature.CreateClient
{
    public partial class CreateClient : Form
    {
        ClientsService service = new();
        ClientAdapter adapter = new();

        public CreateClient()
        {
            InitializeComponent();
        }

        private void CreateClient_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Client newClient = new Client(textBoxCode.Text,
                textBoxName.Text,
                Convert.ToDecimal(textBoxDebt.Text),
                Convert.ToDecimal(textBoxLimitCredit.Text));

           dynamic adaptedClient = adapter.ClientToCSV(newClient);

           service.postClient(adaptedClient);

           ClearField();

        }

        public void ClearField()
        {
            textBoxCode.Clear();
            textBoxName.Clear();
            textBoxDebt.Clear();
            textBoxLimitCredit.Clear();
        }
    }
}
