using Domain.Models;
using Domain.Services;
using Infrastructure.Utils;
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
        List<Article> filteredArticles = new List<Article>();

        ArticlesService articlesService = new ArticlesService();

        CategoriesService categoriesService = new CategoriesService();

        private void buttonExportArticles_Click(object sender, EventArgs e)
        {
            //TODO: Export artciles
            articlesService.PostGenerateReport(filteredArticles);

            MessageBox.Show("Reporte de articulos creado correctamente", "Reporte creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: Selected category
            loadArticles(comboBoxCategories.Text);
        }

        private void ListArticles_Load(object sender, EventArgs e)
        {
            loadCategories();

            loadArticles(comboBoxCategories.Text);           

        }

        private void loadCategories()
        {
            this.comboBoxCategories.Items.Clear();

            List<Category> categories = categoriesService.GetCategories();

            loadCategoriesComboBox(categories);
        }

        private void loadCategoriesComboBox(List<Category> categories)
        {             

            this.comboBoxCategories.Items.Add(CategoryUtils.CATEGORY_ALL_TEXT);

            this.comboBoxCategories.SelectedIndex = CategoryUtils.CATEGORY_ALL_INDEX;

            foreach (Category category in categories)
            {
                this.comboBoxCategories.Items.Add(category.Code);
            }
        }

        private void loadArticles(string selectedCategory)
        {
            var (articles, total, amount) = articlesService.GetArticles(selectedCategory);

            loadArticlesDataGridView(articles);

            filteredArticles = articles;

            labelResults.Text = $"{total} resultados";

            labelTotalAmounts.Text = amount.ToString("C");
        }

        private void loadArticlesDataGridView(List<Article> articles)
        {
            this.dataGridViewArticles.Rows.Clear();

            foreach (Article article in articles)
            {
                decimal priceInStock = article.Stock * article.Price;

                dataGridViewArticles.Rows.Add(article.Code, article.Description, article.Price.ToString("C"), article.Stock, priceInStock.ToString("C"));
            }
        }


    }
}
