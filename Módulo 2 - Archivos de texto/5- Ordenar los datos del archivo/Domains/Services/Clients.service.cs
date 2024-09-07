using Domain.Adapters;
using Domain.Models;
using System.Text;

namespace Domain.Services
{
    internal class ClientsService
    {
        private string filename = "DB_Clients.csv";

        ClientAdapter adapter = new();

        string SEPARATOR = ";";

        string BREAK_LINE = "";

        string COLUMNS_LINE = $"Codigo;Nombre;Deuda;Limite";

        public (List<Client>, int, decimal, decimal) getClients()
        {
            string? clientCSV;

            List<Client> clients = new();

            decimal totalDebts = 0;

            using (StreamReader streamReader = new StreamReader(filename, true))
            {

                clientCSV = streamReader.ReadLine();

                while (clientCSV != null)
                {

                    Client adapted = adapter.CSVToClient(clientCSV);

                    totalDebts += adapted.Debt;

                    clients.Add(adapted);

                    clientCSV = streamReader.ReadLine();
                }

                int totalClients = clients.Count;

                decimal averageDebt = totalDebts / clients.Count;


                return (clients, totalClients, totalDebts, averageDebt);
            }
        }

        public void PostReportClients()
        {
            string? clientCSV;

            decimal totalClients = 0;
            decimal totalDebts = 0;

            using (StreamReader streamReader = new StreamReader(filename, Encoding.UTF8))
            {
                using (StreamWriter streamWriter = new StreamWriter("ReporteClientes.csv", false, Encoding.UTF8))
                {
                    clientCSV = streamReader.ReadLine();

                    string title = $"Reporte de clientes{SEPARATOR}{SEPARATOR}{SEPARATOR}";
                    streamWriter.WriteLine(title);
                    streamWriter.WriteLine(BREAK_LINE);
                    streamWriter.WriteLine(COLUMNS_LINE);

                    while (clientCSV != null)
                    {
                        // Write the CSV line to the report
                        streamWriter.WriteLine(clientCSV);

                        Client adapted = adapter.CSVToClient(clientCSV);

                        totalDebts += adapted.Debt;
                        totalClients += 1;

                        clientCSV = streamReader.ReadLine();
                    }

                    decimal averageDebt = totalClients > 0 ? totalDebts / totalClients : 0;

                    streamWriter.WriteLine(BREAK_LINE);
                    streamWriter.WriteLine($"Total Clients{SEPARATOR}{totalClients}");
                    streamWriter.WriteLine($"Total Debts{SEPARATOR}{totalDebts}");
                    streamWriter.WriteLine($"Average Debt{SEPARATOR}{averageDebt}");
                }
            }
        }

        public (List<Client>, int, decimal, decimal) getDebtorClients()
        {
            string? clientCSV;

            List<Client> clients = new();

            decimal totalDebts = 0;

            using (StreamReader streamReader = new StreamReader(filename, true))
            {

                clientCSV = streamReader.ReadLine();

                while (clientCSV != null)
                {
                    Client adapted = adapter.CSVToClient(clientCSV);

                    clientCSV = streamReader.ReadLine();

                    if (adapted.Debt <= 0)
                    {
                        continue;
                    }

                    totalDebts += adapted.Debt;

                    clients.Add(adapted);

                }

                int totalClients = clients.Count;

                decimal averageDebt = totalDebts / clients.Count;


                return (clients, totalClients, totalDebts, averageDebt);
            }
        }

        public void PostReportDebtorClients()
        {
            string? clientCSV;

            decimal totalClients = 0;
            decimal totalDebts = 0;

            using (StreamReader streamReader = new StreamReader(filename, Encoding.UTF8))
            {
                using (StreamWriter streamWriter = new StreamWriter("ReporteClientesDeudores.csv", false, Encoding.UTF8))
                {
                    clientCSV = streamReader.ReadLine();

                    string title = $"Reporte de clientes deudores{SEPARATOR}{SEPARATOR}{SEPARATOR}";
                    streamWriter.WriteLine(title);
                    streamWriter.WriteLine(BREAK_LINE);
                    streamWriter.WriteLine(COLUMNS_LINE);

                    while (clientCSV != null)
                    {
                        Client adapted = adapter.CSVToClient(clientCSV);

                        clientCSV = streamReader.ReadLine();

                        if (adapted.Debt <= 0)
                        {
                            continue;
                        }
                        streamWriter.WriteLine(clientCSV);

                        totalDebts += adapted.Debt;

                        totalClients += 1;

                    }

                    decimal averageDebt = totalClients > 0 ? totalDebts / totalClients : 0;

                    streamWriter.WriteLine(BREAK_LINE);
                    streamWriter.WriteLine($"Total Clients{SEPARATOR}{totalClients}");
                    streamWriter.WriteLine($"Total Debts{SEPARATOR}{totalDebts}");
                    streamWriter.WriteLine($"Average Debt{SEPARATOR}{averageDebt}");
                }
            }
        }

        public void postClient(string code, string fullName, decimal debt, decimal creditLimit)
        {

            using (StreamWriter streamWriter = new StreamWriter(filename, true))
            {
                Client newClient = new Client(code, fullName, debt, creditLimit);

                dynamic adaptedClient = adapter.ClientToCSV(newClient);

                streamWriter.WriteLine(adaptedClient);
            }
        }
    }
}
