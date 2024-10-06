using System.Data;
using System.Data.OleDb;
using Infrastructure.Utils;

namespace Domain
{
    /// <summary>
    /// Clase que se encarga de gestionar la conexión a la base de datos usando OleDb.
    /// </summary>
    internal class Repository
    {
        private OleDbConnection connection = new OleDbConnection(UtilsRepository.ACCESS_URL);
 

        /// <summary>
        /// Abre la conexión a la base de datos si está cerrada.
        /// </summary>
        private void OpenConnection()
        {
            if (connection.State != ConnectionState.Closed) return;

            connection.Open();
        }

        /// <summary>
        /// Cierra la conexión a la base de datos si está abierta.
        /// </summary>
        private void CloseConnection()
        {
            if (connection.State != ConnectionState.Open) return;

            connection.Close();
        }

        /// <summary>
        /// Ejecuta una consulta SQL que devuelve datos, generalmente de tipo SELECT.
        /// </summary>
        /// <param name="query">Consulta SQL que se desea ejecutar.</param>
        /// <returns>
        /// Un objeto <see cref="DataTable"/> que contiene los resultados de la consulta.
        /// </returns>
        /// <exception cref="Exception">
        /// Lanza una excepción si ocurre un error al ejecutar la consulta o al abrir la conexión.
        /// </exception>
        public DataTable ExecuteQuery(string query)
        {
            try
            {
                // Abre la conexión a la base de datos
                OpenConnection();

                // Crea un comando para ejecutar la consulta SQL
                OleDbCommand command = new OleDbCommand();
                command.CommandText = query;

                command.Connection = connection;

                command.CommandType = CommandType.Text;


                // Usa un adaptador para llenar el DataTable con los resultados de la consulta
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Retorna el DataTable con los datos obtenidos
                return dataTable;
            }
            catch (Exception ex)
            {
                // Lanza una excepción si ocurre un error durante la ejecución
                throw new Exception(ex.Message);
            }
            finally
            {
                // Cierra la conexión a la base de datos
                CloseConnection();
            }
        }

    }
}
