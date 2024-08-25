using Grabar_y_leer_un_archivo_de_texto.Class;

namespace Grabar_y_leer_un_archivo_de_texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Ingrese un texto")
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Ingrese un texto";
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FileClass.Record(textBox.Text);

            MessageBox.Show("Texto grabado correctamente","Grabado de texto",MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox.Text=string.Empty;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            validateText(textBox,button1);
        }

        private void validateText(TextBox textBox,Button button)
        {
            if (textBox.Text == string.Empty)
            {
                button.Enabled = false;
                return;
            }

            button.Enabled = true;
        }
    }
}
