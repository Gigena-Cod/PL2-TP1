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

namespace _2_varias_columnas_de_datos.Feature.ListClients
{
    public partial class ListClients : Form
    {
        public ListClients()
        {
            InitializeComponent();
        }

        ClientsService clientService = new();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dataGridViewClients.Rows.Clear();

            List<Client> clients = clientService.getClients();

            foreach (Client client in clients)
            {
                dataGridViewClients.Rows.Add(client.Code, client.FullName, client.Debt, client.CreditLimit);
            }

        }
    }
}
