using Domain.Models;
using Infrastructure.Utils;

namespace Domain.Adapters
{
    internal class ArticlesAdapter
    {

        public Article? TransformCSVToArticle(string articleCSV)
        {
            string[] propertiesArticle = articleCSV.Split(Utils.CSV_SEPARATOR);

            if (propertiesArticle.Length !=5) {
                return null;
            }

            string code = propertiesArticle[Utils.CODE_POSITION];
            string description = propertiesArticle[Utils.DESCRIPTION_POSITION];
            decimal price = Convert.ToDecimal(propertiesArticle[Utils.PRICE_POSITION]);
            string category = propertiesArticle[Utils.CATEGORY_POSITION];
            int stock = Convert.ToInt32(propertiesArticle[Utils.STOCK_POSITION]);

            Article newArticle = new (code,description,price,category,stock);

            return newArticle;
        }
    }
   
}
