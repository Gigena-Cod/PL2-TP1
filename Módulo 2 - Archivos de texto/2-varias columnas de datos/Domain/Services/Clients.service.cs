using Domain.Adapters;
using Domain.Models;
using System.Windows.Forms;

namespace Domain.Services
{
    internal class ClientsService
    {
        private string filename = "DB_Clients.csv";

        ClientAdapter adapter = new();

        public List<Client> getClients()
        {

            string clientCSV;

            List<Client> clients = new();

            using (StreamReader streamReader = new StreamReader(filename, true))
            {

                clientCSV = streamReader.ReadLine();

                while (clientCSV != null) {

                    Client adapted = adapter.CSVToClient(clientCSV);

                    clients.Add(adapted);

                    clientCSV = streamReader.ReadLine();
                }

                return clients;
            }
        }

        public void postClient(string code, string fullName, decimal debt, decimal creditLimit)
        {
            
            using (StreamWriter streamWriter = new StreamWriter(filename, true))
            {
                Client newClient = new Client(code,fullName,debt,creditLimit);

                dynamic adaptedClient = adapter.ClientToCSV(newClient);

                streamWriter.WriteLine(adaptedClient);
            }
        }
    }
}
