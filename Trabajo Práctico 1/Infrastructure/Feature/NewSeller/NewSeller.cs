using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Práctico_1.Domain.Datasource;
using Trabajo_Práctico_1.Domain.Service;

namespace Trabajo_Práctico_1.Feature.NewSeller
{
    public partial class NewSeller : Form
    {
        public NewSeller()
        {
            InitializeComponent();
        }

        SellerService service = new SellerService();

        private async void buttonCreateSeller_Click(object sender, EventArgs e){
            buttonCreateSeller.Enabled = false;

            SellerService service = new SellerService();

            int.TryParse(textBoxCode.Text, out int code);

            decimal.TryParse(textBoxSalary.Text, out decimal salary);

            bool alreadyExistCode = validateAlreadyExistCode();

            if (alreadyExistCode)
            {
                MessageBox.Show($"Ocurrió un error al crear el vendedor, codigo existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonCreateSeller.Enabled = true;
                textBoxCode.Text = string.Empty;
                return;
            }

            bool response = await service.CreateSellerAsync(code,textBoxName.Text, salary);

            buttonCreateSeller.Enabled = true;

            if (!response) {
                MessageBox.Show($"Ocurrió un error al crear el vendedor", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show("Vendedor agregado con exito", "Cliente creado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxName.Clear();
            textBoxCode.Clear();
            textBoxSalary.Clear();
        }



        private void buttonCloseCreateSellet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewSeller_Load(object sender, EventArgs e)
        {
            buttonCreateSeller.Enabled = false;
        }

        private void validatePayload()
        {
            bool isCodeValid = !string.IsNullOrEmpty(textBoxCode.Text) &&
                               int.TryParse(textBoxCode.Text, out int code) &&
                               code > 0;

            bool isNameValid = !string.IsNullOrEmpty(textBoxName.Text);

            bool isSalaryValid = !string.IsNullOrEmpty(textBoxSalary.Text) &&
                decimal.TryParse(textBoxSalary.Text, out decimal salary) &&
                salary > 0;

            if (!isCodeValid || !isNameValid || !isSalaryValid)
            {
                buttonCreateSeller.Enabled = false;
                return;
            }

            buttonCreateSeller.Enabled = true;

        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {
            validatePayload();
        }

        private void textBoxSalary_TextChanged(object sender, EventArgs e)
        {
            validatePayload();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            validatePayload();
        }

        private bool validateAlreadyExistCode()
        {
            for (int i = 0; i < SellerDatasource.totalSellers; i++) {

                int.TryParse(textBoxCode.Text, out int code);

                if (SellerDatasource.sellers[i].code==code)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
