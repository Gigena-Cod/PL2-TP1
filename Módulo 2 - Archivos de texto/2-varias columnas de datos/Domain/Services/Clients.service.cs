namespace Domain.Services
{
    internal class ClientsService
    {
        private string filename = "DB_Clients.csv";

        public void getClients()
        {
            //TODO: Get clients
            StreamReader streamReader = new StreamReader(filename, true);
        }

        public void postClient(string client)
        {
            StreamWriter streamWriter = new StreamWriter(filename, true);
            
            streamWriter.WriteLine(client);

            streamWriter.Close();
            streamWriter.Dispose();
        }
    }
}
