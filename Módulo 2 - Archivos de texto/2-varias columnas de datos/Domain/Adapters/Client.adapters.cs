using Domain.Models;

namespace Domain.Adapters
{
    internal class ClientAdapter
    {
        public string ClientToCSV(Client client) {

            return $"{client.Code};{client.FullName};{client.Debt};{client.CreditLimit}";
        }
    }
}
