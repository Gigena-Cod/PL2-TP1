using _5__Método_de_burbuja_para_ordenar_datos_de_un_vector.Class;

namespace _5__Método_de_burbuja_para_ordenar_datos_de_un_vector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientService service = new ClientService();

            service.loadMockClients();

            dataGridViewClients.Rows.Clear();

            for(int index=0; index< service.totalRegistries; index++)
            {
                dataGridViewClients.Rows.Add(service.clients[index].code, service.clients[index].name, service.clients[index].debt, service.clients[index].limitCredit);
            }
        }
    }
}
