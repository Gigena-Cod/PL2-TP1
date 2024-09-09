namespace Domain.Models
{
    internal class Category
    {
        public string Code { get; set; }

        public Category(string code)
        {
            Code = code;
        }
    }
}
