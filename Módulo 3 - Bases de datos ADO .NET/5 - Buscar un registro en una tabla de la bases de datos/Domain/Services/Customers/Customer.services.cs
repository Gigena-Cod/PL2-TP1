using Domain;
using Infrastructure.Utils;

namespace _2___Conexión_a_una_base_de_datos.Domain.Services.Customers
{
    internal class CustomerServices
    {
        // Instancia del repositorio
        Repository repository = new();

        /// <summary>
        /// Obtiene todos los usuarios de la tabla Users y los muestra en la consola.
        /// </summary>
        /// <returns>Una lista de Customer o null si ocurre un error.</returns>
        public ResponseGetAllCustomers GetAllUsers()
        {
            int totalCustomers = 0;

            int totalDebts = 0;

            float averageDebts = 0;

            List<Customer> users = new(); // Inicializa la lista de usuarios

            ResponseGetAllCustomers response;

            try
            {
                // Define la consulta SQL para obtener todos los usuarios de la tabla Users
                string query = $"SELECT * FROM [{UtilsRepository.ENTITY_USER}]";


                // Llama al método ExecuteQuery del repositorio y obtiene la lista de filas
                List<List<object>>? usersRows = repository.ExecuteQuery(query);

                // Si no hay resultados, devuelve una lista vacía
                if (usersRows == null || usersRows.Count == 0){
                    response = new(users, totalCustomers, totalDebts, averageDebts);
                    return response;
                }

                // Recorre las filas para construir los objetos Customer
                foreach (List<object> row in usersRows)
                {
                    int id = Convert.ToInt32(row[0]);
                    string name = row[1].ToString();
                    string lastName = row[2].ToString();
                    string email = row[3].ToString();
                    int debt = Convert.ToInt32(row[5]);

                    Customer customer = new(id, name, lastName, email, debt);

                    users.Add(customer); // Agrega el objeto Customer a la lista
                    totalCustomers++;
                    totalDebts += customer.Debt;
                }

                averageDebts = totalDebts / totalCustomers;

                response = new(users,totalCustomers,totalDebts,averageDebts);

                return response; // Devuelve la lista de usuarios
            }
            catch (Exception ex)
            {
                response = new(users, totalCustomers, totalDebts, averageDebts);
                return response;
            }
        }

        public Customer? GetUserByCode(string code)
        {
            try
            {
                // Define la consulta SQL para obtener un usuario específico según su código 
                string query = $"SELECT * FROM [{UtilsRepository.ENTITY_USER}] WHERE [ID] = {code}";

                // Llama al método ExecuteQuery del repositorio y obtiene la lista de filas (una lista de objetos o null)
                var response = repository.ExecuteQuery(query);

                // Si el resultado es null o no contiene filas, devuelve null
                if (response == null || response.Count == 0){
                    
                    return null;
                }

                if (response.Count > 1) return null;

                List<object> arrayCustomer = response[0];

                int id = Convert.ToInt32(arrayCustomer[0]);
                string name = arrayCustomer[1].ToString();
                string lastName = arrayCustomer[2].ToString();
                string email = arrayCustomer[3].ToString();
                int debt = Convert.ToInt32(arrayCustomer[5]);

                Customer customer = new(id, name, lastName, email, debt);                  

                return customer; // Devuelve el objeto Customer
              
            }
            catch (Exception ex)
            {
                // Manejo de excepción, puedes registrar el error o hacer otras acciones
                return null;
            }
        }

    }
}
