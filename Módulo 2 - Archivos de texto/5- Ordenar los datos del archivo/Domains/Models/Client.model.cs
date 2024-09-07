using System;

namespace Domain.Models
{
    internal class Client
    {
        public string Code { get; set; }
        public string FullName { get; set; }
        public decimal Debt { get; set; }
        public decimal CreditLimit { get; set; }

        public Client(string code, string fullName, decimal debt, decimal creditLimit)
        {
            Code = code;
            FullName = fullName;
            Debt = debt;
            CreditLimit = creditLimit;
        }
    }
}
