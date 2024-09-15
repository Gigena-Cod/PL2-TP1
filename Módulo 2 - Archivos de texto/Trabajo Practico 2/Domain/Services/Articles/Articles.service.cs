using Domain.Adapters;
using Domain.Models;
using Infrastructure.Utils;
using System.Text;

namespace Domain.Services
{
    internal class ArticlesService
    {
        ArticlesAdapter adapter = new();
         

        public (List<Article>,int totalArticles,decimal totalAmounts) GetArticles(string? category)
        {

            List<Article> articles = new List<Article>();
            
            int total = 0;

            decimal amount = 0;

            using (StreamReader streamReader = new(ArticlesUtils.ArticlesFilename))
            {
                string? article = streamReader.ReadLine();

                while (article != null)
                {
                    Article? adaptedArticle = adapter.TransformCSVToArticle(article);

                    article = streamReader.ReadLine();

                    if(adaptedArticle != null && (category==CategoryUtils.CATEGORY_ALL_TEXT || category == adaptedArticle.Category))
                    {
                        amount += adaptedArticle.Price * Convert.ToDecimal(adaptedArticle.Stock);
                        total += 1;
                        articles.Add(adaptedArticle);
                    } 

                }

            }

             return (articles,total,amount);
        }
    
        public void PostGenerateReport(List<Article> articles)
        {

            using(StreamWriter streamWriter = new(ArticlesUtils.ArticlesReportFilename, false, Encoding.UTF8))
            {
                streamWriter.WriteLine("Reporte de Articulos");
                streamWriter.WriteLine("");

                streamWriter.WriteLine("Codigo;Descripcion;Rubro;Precio;Stock");

                foreach (Article article in articles)
                {
                    string adaptedArticle = adapter.TransformArticleToCSV(article);
                    streamWriter.WriteLine(adaptedArticle);
                }
            }


        }
    }
}
