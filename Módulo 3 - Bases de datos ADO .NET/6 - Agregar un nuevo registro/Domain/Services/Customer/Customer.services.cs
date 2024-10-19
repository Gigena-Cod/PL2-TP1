using Infrastructure.Features;

namespace Domain.Services
{
    public class CustomerService
    {
        public bool CreateCustomer(string name, string lastName,string limitCredit, string address, string city,string province,string country)
        {
            string query = "INSERT INTO CUSTOMER (name, lastName, limitCredit, address, city, province, country) " +
                   $"VALUES ({name}, {lastName}, {limitCredit}, {address}, {city}, {province}, {country})";


            return true;
        }
    }
}
