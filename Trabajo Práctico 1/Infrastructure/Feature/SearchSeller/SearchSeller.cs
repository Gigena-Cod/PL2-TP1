using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Práctico_1.Domain.Models;
using Trabajo_Práctico_1.Domain.Service;

namespace Trabajo_Práctico_1.Infrastructure.Feature.SearchSeller
{
    public partial class SearchSeller : Form
    {
        public SearchSeller()
        {
            InitializeComponent();
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            SellerService service = new SellerService();

            labelName.Text = "-";

            labelSalary.Text = "-";

            buttonSearch.Enabled = false;

            int.TryParse(textBoxCode.Text, out int code);

            Seller.SellerStruct? findSeller = await service.GetSellerAsync(code);

            buttonSearch.Enabled = true;
            if (findSeller == null) {
                MessageBox.Show("Vendedor inexistente", "Usuario inexistenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            labelName.Text = findSeller.Value.name;
            labelSalary.Text = findSeller.Value.salary.ToString("C"); 

        }
    }
}
