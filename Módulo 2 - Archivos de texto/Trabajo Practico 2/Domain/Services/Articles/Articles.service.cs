using Domain.Adapters;
using Domain.Models;
using Infrastructure.Utils;

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
    }
}
