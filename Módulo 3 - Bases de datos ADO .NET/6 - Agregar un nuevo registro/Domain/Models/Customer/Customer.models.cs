namespace Domain.Models
{
    public class Customer
    {
        public  Customer(int ID, string name, string lastName, int Debts,int LimitCredit,string Country) {
            this.Id = ID;
            this.Name = name;
            this.LastName = lastName;   
            this.Debts = Debts;
            this.LimitCredit = LimitCredit;
            this.Province = Country;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public int Debts { get; set; }

        public int LimitCredit { get; set; }

        public string Province { get; set; }

    }
}
