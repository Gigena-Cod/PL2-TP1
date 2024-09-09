using Domain.Adapters;
using Domain.Models;
using System.Collections.Generic;

namespace Domain.Services
{
    internal class ArticlesService
    {
        ArticlesAdapter adapter = new();

        private string ArticlesFilename = "DB_ARTICULOS.csv";

        public (List<Article>,int totalArticles,decimal totalAmounts) GetArticles()
        {

            List<Article> articles = new List<Article>();
            
            int total = 0;

            decimal amount = 0;

            using (StreamReader streamReader = new(ArticlesFilename))
            {
                string? article = streamReader.ReadLine();

                while (article != null)
                {
                    Article? adaptedArticle = adapter.TransformCSVToArticle(article);

                    article = streamReader.ReadLine();

                    if(adaptedArticle != null)
                    {
                        amount += adaptedArticle.Price * Convert.ToDecimal(adaptedArticle.Stock);
                        total += 1;
                        articles.Add(adaptedArticle);
                    } 

                }

            }

             return (articles,total,amount);
        }
    }
}
