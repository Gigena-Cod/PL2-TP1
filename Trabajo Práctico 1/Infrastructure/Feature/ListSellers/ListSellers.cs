using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Práctico_1.Domain.Service;
using Trabajo_Práctico_1.Domain.Models;
using Trabajo_Práctico_1.Domain.Datasource;

namespace Trabajo_Práctico_1.Feature.ListSellers
{
    public partial class ListSellers : Form
    {
        public ListSellers()
        {
            InitializeComponent();
        }

        private async void ListSellers_Load(object sender, EventArgs e)
        {
            comboBoxField.SelectedIndex = 0;
            comboBoxSortBy.SelectedIndex = 0;

            GetAllSellers();

        }

        private async void GetAllSellers()
        {
            try
            {


                dataGridViewSellers.Enabled = false;

                labelResuelt.Text = "Cargando...";

                labelSalary.Text = "";

                comboBoxField.Enabled = false;

                comboBoxSortBy.Enabled = false;

                dataGridViewSellers.Rows.Clear();

                SellerService service = new SellerService();

                Seller.SellerStruct[] response = await service.GetAllSellerAsync(comboBoxField.SelectedIndex, comboBoxSortBy.SelectedIndex);

                decimal accSalaries = 0;

                for (int i = 0; i < SellerDatasource.totalSellers; i++)
                {
                    dataGridViewSellers.Rows.Add(response[i].code, response[i].name, response[i].salary.ToString("C"));

                    accSalaries += response[i].salary;
                }

                labelResuelt.Text = $"{SellerDatasource.totalSellers} vendedores";

                labelSalary.Text = accSalaries.ToString("C");
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al cargar los vendedores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                dataGridViewSellers.Enabled = true;

                comboBoxField.Enabled = true;

                comboBoxSortBy.Enabled = true;
            }


        }
        private void label4_Click(object sender, EventArgs e)
        {

        }       

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            GetAllSellers();
        }
    }
}
