using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infrastructure.Features
{
    public partial class ListArticles : Form
    {
        public ListArticles()
        {
            InitializeComponent();
        }

        private void buttonExportArticles_Click(object sender, EventArgs e)
        {
            //TODO: Export artciles
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: Selected category
        }
    }
}
