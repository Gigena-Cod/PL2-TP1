using Trabajo_Práctico_1.Domain.Datasource;
using Trabajo_Práctico_1.Feature.ListSellers;
using Trabajo_Práctico_1.Feature.NewSeller;
using Trabajo_Práctico_1.Infrastructure.Feature.SearchSeller;

namespace Trabajo_Práctico_1
{
    public partial class formSalesManagement : Form
    {
        public formSalesManagement()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutMe formAboutMe = new FormAboutMe();
            formAboutMe.ShowDialog();
        }

        private void agregarNuevoVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSeller formNewSeller = new NewSeller();
            formNewSeller.ShowDialog();
        }

        private void listadoGeneralDeVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListSellers listSellers = new ListSellers();
            listSellers.ShowDialog();

        }

        private void formSalesManagement_Load(object sender, EventArgs e)
        {
            SellerDatasource.LoadMock();
        }

        private void consultaDeDatosDeUnVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchSeller searchSeller = new SearchSeller();
            searchSeller.ShowDialog();
        }
    }
}
