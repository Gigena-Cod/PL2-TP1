using Domain;
using System.Diagnostics;

namespace Domain.Services
{
    public class CustomerService
    {
        private Repository repository = new Repository(); // Instancia de Repository


        /// <summary>
        /// Inserta un nuevo cliente en la tabla Customers.
        /// </summary>
        /// <param name="name">El nombre del cliente.</param>
        /// <param name="lastName">El apellido del cliente.</param>
        /// <param name="limitCredit">El límite de crédito del cliente.</param>
        /// <param name="provinceId">La provincia del cliente.</param>
        /// <returns>True si la inserción fue exitosa, de lo contrario false.</returns>
        public bool CreateCustomer(string name, string lastName, string limitCredit,string provinceId)
        {
            string query = "INSERT INTO [Customers] (name, lastName, limitCredit, debts, province) " +
                           $"VALUES ('{name}', '{lastName}', '{limitCredit}','{0}', '{provinceId}')";

            List<List<object>>? response = repository.ExecuteQuery(query);

            if(response==null)
            {
                return false;
            }

            return true;
        }
    }
}
