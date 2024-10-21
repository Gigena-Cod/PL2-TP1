using System.Data.OleDb;

namespace Domain
{
    internal class Repository
    {
        static string CONNECTION_STRING = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='Database.mdb'";

        private OleDbConnection connection = new OleDbConnection(CONNECTION_STRING);

        private void OpenConnection()
        {
            if (this.connection.State == System.Data.ConnectionState.Open) return;

            this.connection.Open();
        }

        private void CloseConnection()
        {
            if (this.connection.State == System.Data.ConnectionState.Closed) return;

            this.connection.Close();
        }


        public List<List<object>>? ExecuteQuery(string query)
        {
            try
            {
                OpenConnection();

                using (OleDbCommand oleDbCommand = new OleDbCommand(query, connection))
                {
                    oleDbCommand.CommandType = System.Data.CommandType.Text;

                    using (OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader())
                    {
                        if (oleDbDataReader == null || oleDbDataReader.FieldCount == 0)
                        {
                            return new List<List<object>>();
                        }

                        List<List<object>> response = new();


                        while (oleDbDataReader.Read())
                        {
                            List<object> row = new List<object>();

                            for (int i = 0; i < oleDbDataReader.FieldCount; i++)
                            {
                                object property = oleDbDataReader[i];

                                row.Add(property);

                            }

                            response.Add(row);
                        }

                        return response;
                    }

                }

            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                CloseConnection();
            }

        }


        public int ExecuteNonQuery(string query, params OleDbParameter[] parameters)
        {
            try
            {
                OpenConnection();

                using (OleDbCommand oleDbCommand = new OleDbCommand(query, connection))
                {
                    oleDbCommand.CommandType = System.Data.CommandType.Text;

                    // Añadir los parámetros si hay
                    if (parameters != null)
                    {
                        oleDbCommand.Parameters.AddRange(parameters);
                    }

                    return oleDbCommand.ExecuteNonQuery(); // Retorna el número de filas afectadas
                }
            }
            catch (Exception ex) // Captura la excepción
            {
                // Podrías registrar el error aquí
                Console.WriteLine($"Error: {ex.Message}");
                return 0; // Retorna 0 en caso de error
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
