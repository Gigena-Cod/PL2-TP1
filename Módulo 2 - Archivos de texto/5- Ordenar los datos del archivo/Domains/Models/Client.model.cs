using System;

namespace Domain.Models
{
    internal class Client
    {
        public int Code { get; set; }
        public string FullName { get; set; }
        public decimal Debt { get; set; }
        public decimal CreditLimit { get; set; }

        public Client(int code, string fullName, decimal debt, decimal creditLimit)
        {
            Code = code;
            FullName = fullName;
            Debt = debt;
            CreditLimit = creditLimit;
        }
    }
}
