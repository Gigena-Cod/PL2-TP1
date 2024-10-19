using Domain;

namespace Domain.Services
{
    public class CustomerService
    {
        private Repository repository = new Repository(); // Instancia de Repository



        public bool CreateCustomer(string name, string lastName, string limitCredit, string address, string city, string province, string country)
        {
            // Construir la consulta de inserción con parámetros
            string query = "INSERT INTO [Customers] (name, lastName, limitCredit, address, city, province, country) " +
                           $"VALUES ('{name}', '{lastName}', '{limitCredit}', '{address}', '{city}', '{province}', '{country}')";


            List<List<object>>? response = repository.ExecuteQuery(query);

            if(response==null)
            {
                return false;
            }
            return true;
        }
    }
}
