namespace Domain
{
    internal class ResponseGetAllCustomers
    {
        // Campos privados
        private List<Customer> customers;
        private int totalCustomer;
        private int totalDebts;
        private float averageDebts;

        // Constructor
        public ResponseGetAllCustomers(List<Customer> customers, int totalCustomer, int totalDebts, float averageDebts)
        {
            this.customers = customers;
            this.totalCustomer = totalCustomer;
            this.totalDebts = totalDebts;
            this.averageDebts = averageDebts;
        }

        // Propiedades públicas para acceder a los campos
        public List<Customer> Customers
        {
            get { return customers; }
        }

        public int TotalCustomer
        {
            get { return totalCustomer; }
        }

        public int TotalDebts
        {
            get { return totalDebts; }
        }

        public float AverageDebts
        {
            get { return averageDebts; }
        }
    }
}
