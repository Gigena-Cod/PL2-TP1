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
using Trabajo_Práctico_1.Infrastructure.Utils;

namespace Trabajo_Práctico_1.Feature.ListSellers
{
    public partial class ListSellers : Form
    {
        public ListSellers()
        {
            InitializeComponent();
        }

        private void ListSellers_Load(object sender, EventArgs e)
        {
            comboBoxField.SelectedIndex = Globals.COMBO_BOX_FIELD_CODE;
            comboBoxSortBy.SelectedIndex = Globals.COMBO_BOX_SORT_BY_ASC;

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

                buttonSearch.Enabled = false;                

                SellerService service = new SellerService();

                Seller.SellerStruct[] response = await service.GetAllSellerAsync(comboBoxField.SelectedIndex, comboBoxSortBy.SelectedIndex);

                dataGridViewSellers.Rows.Clear();

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

                buttonSearch.Enabled = true;
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
