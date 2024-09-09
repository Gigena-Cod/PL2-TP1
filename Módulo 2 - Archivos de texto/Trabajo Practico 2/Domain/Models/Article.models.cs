namespace Domain.Models
{
    internal class Article
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }

        public Article(string code, string description,decimal price, string category, int stock){
            Code = code;
            Description = description;
            Price = price;
            Category = category;
            Stock = stock;
        }
    }
}
