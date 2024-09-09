using Domain.Models;
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

namespace Infrastructure.Features
{
    public partial class ListArticles : Form
    {
        public ListArticles()
        {
            InitializeComponent();
        }

        ArticlesService articlesService = new ArticlesService();

        private void buttonExportArticles_Click(object sender, EventArgs e)
        {
            //TODO: Export artciles
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: Selected category
        }

        private void ListArticles_Load(object sender, EventArgs e)
        {
            this.dataGridViewArticles.Rows.Clear();
            
            List<Article> articles = articlesService.GetArticles();

            foreach (Article article in articles)
            {
                dataGridViewArticles.Rows.Add(article.Code, article.Description, article.Price, article.Stock, article.Code);
            }

        }
    }
}
