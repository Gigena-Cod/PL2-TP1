using Domain.Models;
using Infrastructure.Utils;

namespace Domain.Adapters
{
    internal class ArticlesAdapter
    {

        public Article? TransformCSVToArticle(string articleCSV)
        {
            string[] propertiesArticle = articleCSV.Split(ArticlesUtils.CSV_SEPARATOR);

            if (propertiesArticle.Length !=5) {
                return null;
            }

            string code = propertiesArticle[ArticlesUtils.CODE_POSITION];
            string description = propertiesArticle[ArticlesUtils.DESCRIPTION_POSITION];
            decimal price = Convert.ToDecimal(propertiesArticle[ArticlesUtils.PRICE_POSITION]);
            string category = propertiesArticle[ArticlesUtils.CATEGORY_POSITION];
            int stock = Convert.ToInt32(propertiesArticle[ArticlesUtils.STOCK_POSITION]);

            Article newArticle = new (code,description,price,category,stock);

            return newArticle;
        }

        public string TransformArticleToCSV(Article article)
        { 

            string newArticle = $"{article.Code}{ArticlesUtils.CSV_SEPARATOR}{article.Description}{ArticlesUtils.CSV_SEPARATOR}{article.Category}{ArticlesUtils.CSV_SEPARATOR}{article.Price}{ArticlesUtils.CSV_SEPARATOR}{article.Stock}";

            return newArticle;
        }
    }
   
}
