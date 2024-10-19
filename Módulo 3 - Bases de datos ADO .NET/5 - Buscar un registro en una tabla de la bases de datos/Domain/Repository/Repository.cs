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
        /// Una lista de listas de objetos, donde cada lista interna representa una fila de la consulta,
        /// o null si no hay resultados.
        /// </returns>
        /// <exception cref="Exception">
        /// Lanza una excepción si ocurre un error al ejecutar la consulta o al abrir la conexión.
        /// </exception>
        public List<List<object>>? ExecuteQuery(string query)
        {
            try
            {
                // Abre la conexión a la base de datos
                OpenConnection();

                // Crea un comando para ejecutar la consulta SQL
                OleDbCommand command = new OleDbCommand(query, connection);
                command.CommandType = CommandType.Text;

                // Ejecuta la consulta y obtiene un lector de datos
                OleDbDataReader reader = command.ExecuteReader();

                // Si no hay filas, devuelve null
                if (!reader.HasRows) return null;

                // Lista para almacenar las filas de resultados
                List<List<object>> rows = new List<List<object>>();
                
                // Lee cada fila del lector
                while (reader.Read())
                {

                    // Lista para almacenar los valores de una fila
                    List<object> row = new List<object>();

                    if (reader.FieldCount == 0) continue;

                    // Itera a través de todas las columnas de la fila
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        // Agrega el valor de la columna a la lista de la fila
                        row.Add(reader.GetValue(i));
                    } 
                 
                    // Agrega la fila a la lista de filas
                    rows.Add(row);
                }

                // Devuelve la lista de filas
                return rows;
            }
            catch (Exception ex)
            {
                // Lanza una excepción si ocurre un error durante la ejecución
                throw new Exception("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión a la base de datos
                CloseConnection();
            }
        }

    }
}
