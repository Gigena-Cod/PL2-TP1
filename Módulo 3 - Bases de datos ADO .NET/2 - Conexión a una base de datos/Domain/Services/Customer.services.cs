using System.Data;

namespace Domain
{
    internal class CustomerServices
    {
        // Instancia del repositorio
        Repository repository = new();

        /// <summary>
        /// Obtiene todos los usuarios de la tabla Users y los muestra en la consola.
        /// </summary>
        /// <returns>Una lista de Customer o null si ocurre un error.</returns>
        public List<Customer> GetAllUsers()
        {
            try
            {
                // Define la consulta SQL para obtener todos los usuarios de la tabla Users
                string query = "SELECT * FROM [User]";
                List<Customer> users = new (); // Inicializa la lista de usuarios

                // Llama al método ExecuteQuery del repositorio y obtiene el DataTable con los resultados
                DataTable usersTable = repository.ExecuteQuery(query);

                // Recorre el DataTable para mostrar los usuarios
                foreach (DataRow row in usersTable.Rows)
                {
                    Customer customer = new Customer
                    {
                        Id = Convert.ToInt32(row["user_id"]), // Asegúrate de que el nombre de la columna sea correcto
                        Name = row["first_name"].ToString(),
                        LastName = row["last_name"]?.ToString(), // Usa ? para manejar valores nulos
                        Email = row["email"]?.ToString() // Maneja valores nulos también
                    };
                    users.Add(customer); // Agrega el objeto Customer a la lista
                }

                return users; // Devuelve la lista de usuarios
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los usuarios: " + ex.Message);
                return null; // Retorna null en caso de error
            }
        }

    }
}
