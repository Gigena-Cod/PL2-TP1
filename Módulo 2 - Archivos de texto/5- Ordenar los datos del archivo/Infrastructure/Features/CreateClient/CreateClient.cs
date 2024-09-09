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

namespace Features
{
    public partial class CreateClient : Form
    {
        public CreateClient()
        {
            InitializeComponent();
        }

        ClientsService service = new ();

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            service.postClient(
                 Convert.ToInt16(textBoxCode.Text),
                  textBoxName.Text,
                  Convert.ToDecimal(textBoxDebt.Text),
                  Convert.ToDecimal(textBoxLimitCredit.Text));

            ClearField();

            MessageBox.Show("El cliente ha sido registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
