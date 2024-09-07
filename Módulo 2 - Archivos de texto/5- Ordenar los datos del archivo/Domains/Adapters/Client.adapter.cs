using Domain.Models;

namespace Domain.Adapters
{
    internal class ClientAdapter
    {
        private const int CODE_INDEX = 0;
        private const int FULL_NAME_INDEX = 1;
        private const int DEBT_INDEX = 2;
        private const int LIMIT_CREDIT_INDEX = 3;
        private const string SEPARATOR = ";";

        public string ClientToCSV(Client client)
        {

            return $"{client.Code}{SEPARATOR}{client.FullName}{SEPARATOR}{client.Debt}{SEPARATOR}{client.CreditLimit}";
        }

        public Client CSVToClient(string client)
        {
            string[] properties = client.Split(SEPARATOR);

            if (properties.Length != 4)
            {
                throw new ArgumentException("El formato del CSV es incorrecto.");
            }

            return new Client(
                properties[CODE_INDEX],
                properties[FULL_NAME_INDEX],
                Convert.ToDecimal(properties[DEBT_INDEX]),
                Convert.ToDecimal(properties[LIMIT_CREDIT_INDEX])
            );
        }
      
    }
}
