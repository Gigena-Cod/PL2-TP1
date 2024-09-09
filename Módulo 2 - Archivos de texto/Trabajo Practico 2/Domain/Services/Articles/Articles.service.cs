using Domain.Adapters;
using Domain.Models;
using System.Collections.Generic;

namespace Domain.Services
{
    internal class ArticlesService
    {
        ArticlesAdapter adapter = new();

        private string ArticlesFilename = "DB_ARTICULOS.csv";

        public List<Article> GetArticles()
        {

            List<Article> articles = new List<Article>();

            using (StreamReader streamReader = new(ArticlesFilename))
            {
                string? article = streamReader.ReadLine();

                while (article != null)
                {
                    Article? adaptedArticle = adapter.TransformCSVToArticle(article);

                    article = streamReader.ReadLine();

                    if(adaptedArticle != null)
                    {
                        articles.Add(adaptedArticle);
                    } 

                }

            }

             return articles;
        }
    }
}
