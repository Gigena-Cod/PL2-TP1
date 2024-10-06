namespace Domain
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }

        public int Debt { get; set; }

        public Customer(int Id,string Name, string LastName, string Email, int Debt)
        {
            this.Id = Id;
            this.Name = Name;
            this.LastName = LastName;
            this.Email = Email;
            this.Debt = Debt;
        }
    }
}
