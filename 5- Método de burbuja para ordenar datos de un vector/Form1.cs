using _5__Método_de_burbuja_para_ordenar_datos_de_un_vector.Class;

namespace _5__Método_de_burbuja_para_ordenar_datos_de_un_vector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int CLIENT_CODE = 0;
        const int CLIENT_NAME = 1;
        const int CLIENT_DEBT = 2;
        const int CLIENT_LIMIT_CREDIT = 3;

        const int SORT_BY_ASC = 0;
        const int SORT_BY_DESC = 1;

        ClientService service = new ClientService();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxField.SelectedIndex = CLIENT_CODE;
            comboBoxSortBy.SelectedIndex = SORT_BY_DESC;
            service.loadMockClients();
            LoadDataGridViewClients();
        }

        private void LoadDataGridViewClients()
        {

            dataGridViewClients.Rows.Clear();

            switch (comboBoxField.SelectedIndex)
            {
                case CLIENT_CODE:
                    if (comboBoxSortBy.SelectedIndex == SORT_BY_ASC)
                    {
                        service.GetClientSortByCodeAsc();
                        break;
                    }
                    else { 
                    }
                    service.GetClientSortByCodeDesc();
                    break;

                case CLIENT_NAME:
                    if (comboBoxSortBy.SelectedIndex == SORT_BY_ASC)
                    {
                        service.GetClientSortByNameAsc();
                        break;
                    }

                    service.GetClientSortByNameDesc();
                    break;

                case CLIENT_DEBT:
                    if (comboBoxSortBy.SelectedIndex == SORT_BY_ASC)
                    {
                        service.GetClientSortByDebtsAsc();
                        break;
                    }

                    service.GetClientSortByDebtsDesc();
                    break;

                case CLIENT_LIMIT_CREDIT:
                    if (comboBoxSortBy.SelectedIndex == SORT_BY_ASC)
                    {
                        service.GetClientSortByLimitCreditAsc();
                        break;
                    }

                    service.GetClientSortByLimitCreditDesc();
                    break;

                default:
                    MessageBox.Show("Selecciona un campo válido para ordenar.", "Campo no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

            for (int index = 0; index < service.totalClients; index++)
            {
                dataGridViewClients.Rows.Add(service.clients[index].code, service.clients[index].name, service.clients[index].debt, service.clients[index].limitCredit);
            }
        }

        private void comboBoxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridViewClients();
        }

        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridViewClients();
        }
    }
}
