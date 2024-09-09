using Domain.Models;
using Infrastructure.Utils;

namespace Domain.Services
{
    internal class CategoriesService
    {
        public List<Category> GetCategories() {

            List<Category> categories = new List<Category>();

            using (StreamReader StreamReader = new StreamReader(CategoryUtils.CategoriesFilename, false))
            {
                string? categoryCSV = StreamReader.ReadLine();

                while (categoryCSV != null) {

                    Category category = new (categoryCSV);

                    categories.Add(category);

                    categoryCSV = StreamReader.ReadLine();
                }

            }

            return categories;
        }
    }
        
}
