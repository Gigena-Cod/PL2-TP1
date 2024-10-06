using Features;

namespace Infrastructure.Features
{
    public partial class ArticlesManagement : Form
    {
        public ArticlesManagement()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListArticles listArticles = new ListArticles();
            listArticles.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe aboutMe = new AboutMe();
            aboutMe.ShowDialog();
        }

        private void ArticlesManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
