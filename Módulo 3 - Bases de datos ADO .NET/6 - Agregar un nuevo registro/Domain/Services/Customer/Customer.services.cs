using Domain;
using Domain.Models;
using Infrastructure.Features;
using System.Data.OleDb;
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
        public bool CreateCustomer(string name, string lastName, string limitCredit, int provinceId)
        {
            string query = "INSERT INTO customers (firstName, lastName, limitCredit, debts, province) " +
                           $"VALUES ('{name}', '{lastName}', '{limitCredit}','{0}', '{provinceId}')";

            List<List<object>>? response = repository.ExecuteQuery(query);

            if (response == null)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Obtiene todos los clientes junto con sus deudas, límite de crédito y el país asociado.
        /// </summary>
        /// <returns>Una lista de objetos Customer, o una lista vacía si no hay resultados.</returns>
        public List<Customer>? GetAllCustomers()
        {
            // Construir la consulta para obtener los datos de los clientes y sus países
            string query = "SELECT customers.Id,customers.firstName, customers.lastName, customers.debts, customers.limitCredit, provinces.label " +
                "FROM customers INNER JOIN provinces " +
                "ON customers.province = provinces.Id " +
                "ORDER BY customers.Id";

            List<List<object>>? response = repository.ExecuteQuery(query);

            if (response == null)
            {
                return new List<Customer>();
            }

            List<Customer> customers = new List<Customer>();

            // Iterar sobre la respuesta para crear objetos Customer
            foreach (List<object> customer in response)
            {
                if (customer.Count == 0 || customer == null) continue;

                int id = Convert.ToInt32(customer[0]);
                string name = customer[1].ToString();
                string lastName = customer[2].ToString();
                int debts = Convert.ToInt32(customer[3]);
                int limitCredit = Convert.ToInt32(customer[4]); // Asegúrate de que se convierte correctamente si es un número
                string country = customer[5].ToString();

                Customer formattedCustomer = new Customer(id, name, lastName, debts, limitCredit, country);
                customers.Add(formattedCustomer);
            }

            return customers;
        }


        public Customer? GetCustomerById(string customerId)
        {

            string query = "SELECT customers.Id,customers.firstName, customers.lastName, customers.debts, customers.limitCredit, provinces.label " +
                "FROM customers INNER JOIN provinces " +
                "ON customers.province = provinces.Id " +
                $"WHERE customers.Id = {customerId}";

            List<List<object>>? response = repository.ExecuteQuery(query);

            if (response == null || response.Count == 0 || response.Count > 1) return null;

            Customer customer;

            List<object> customerRow = response[0];

            int id = Convert.ToInt32(customerRow[0]);
            string name = customerRow[1].ToString();
            string lastName = customerRow[2].ToString();
            int debts = Convert.ToInt32(customerRow[3]);
            int limitCredit = Convert.ToInt32(customerRow[4]); // Asegúrate de que se convierte correctamente si es un número
            string country = customerRow[5].ToString();

            Customer formattedCustomer = new Customer(id, name, lastName, debts, limitCredit, country);

            customer = formattedCustomer;

            return customer;
        }

        public bool DeleteCustomer(string deleteCustomerId)
        {
            // Usar parámetros para evitar inyecciones SQL
            string query = "DELETE FROM customers WHERE Id = @customerId";

            // Crear el parámetro
            OleDbParameter parameter = new OleDbParameter("@customerId", deleteCustomerId);

            // Ejecutar la consulta y obtener el número de filas afectadas
            int rowsAffected = repository.ExecuteNonQuery(query, parameter);

            // Retornar true si se eliminó al menos un registro, false en caso contrario
            return rowsAffected > 0;
        }

        public bool UpdateCustomer(int customerId, string firstName, string lastName, decimal limitCredit, int province)
        {
            string query = "UPDATE customers SET firstName = @firstName, lastName = @lastName, limitCredit = @limitCredit, province = @province WHERE Id = @Id";

            OleDbParameter[] parameters = new OleDbParameter[]
            {
                new OleDbParameter("@firstName", firstName),
                new OleDbParameter("@lastName", lastName),
                new OleDbParameter("@limitCredit", limitCredit),
                new OleDbParameter("@province", province),
                new OleDbParameter("@Id", customerId) // El último parámetro es el Id
            };

            // Llama al método ExecuteNonQuery del repositorio
            int rowsAffected = repository.ExecuteNonQuery(query, parameters);
             

            return rowsAffected > 0; // Devuelve true si se actualizó al menos una fila
        }



    }
}
