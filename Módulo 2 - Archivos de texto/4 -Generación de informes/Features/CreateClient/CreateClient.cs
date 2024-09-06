using Domain.Services;

namespace _2_varias_columnas_de_datos.Feature.CreateClient
{
    public partial class CreateClient : Form
    {
        ClientsService service = new();

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
           service.postClient(textBoxCode.Text,
                textBoxName.Text,
                Convert.ToDecimal(textBoxDebt.Text),
                Convert.ToDecimal(textBoxLimitCredit.Text));

           ClearField();

           MessageBox.Show("El cliente ha sido registrado exitosamente","Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
