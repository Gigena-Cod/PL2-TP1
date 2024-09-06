using Domain.Adapters;
using Domain.Models;
using System.Windows.Forms;

namespace Domain.Services
{
    internal class ClientsService
    {
        private string filename = "DB_Clients.csv";

        ClientAdapter adapter = new();

        public (List<Client>,int,decimal, decimal) getClients()
        {
            string? clientCSV;

            List<Client> clients = new();

            decimal totalDebts = 0;

            using (StreamReader streamReader = new StreamReader(filename, true))
            {

                clientCSV = streamReader.ReadLine();

                while (clientCSV != null) {

                    Client adapted = adapter.CSVToClient(clientCSV);

                    totalDebts += adapted.Debt;

                    clients.Add(adapted);

                    clientCSV = streamReader.ReadLine();
                }

                int totalClients = clients.Count;

                decimal averageDebt = totalDebts/clients.Count;


                return (clients, totalClients, totalDebts, averageDebt);
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
