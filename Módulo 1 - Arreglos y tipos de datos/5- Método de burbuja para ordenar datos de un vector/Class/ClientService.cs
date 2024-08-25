using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Método_de_burbuja_para_ordenar_datos_de_un_vector.Class
{
   internal class ClientService
    {

        public struct Client
        {
            public string code;
            public string name;
            public decimal debt;
            public decimal limitCredit;
        }

       public Client[] clients = new Client[100];
        
        public int totalClients = 0;

       
        public void loadMockClients()
        {
            clients[0] = new Client { code = "C001", name = "John Doe", debt = 1000.0m, limitCredit = 5000.0m };
            clients[1] = new Client { code = "C002", name = "Jane Smith", debt = 250.0m, limitCredit = 2000.0m };
            clients[2] = new Client { code = "C003", name = "Michael Brown", debt = 1500.0m, limitCredit = 7000.0m };
            clients[3] = new Client { code = "C004", name = "Emily Davis", debt = 300.0m, limitCredit = 1500.0m };
            clients[4] = new Client { code = "C005", name = "David Wilson", debt = 800.0m, limitCredit = 4000.0m };
            clients[5] = new Client { code = "C006", name = "Sarah Miller", debt = 450.0m, limitCredit = 3500.0m };
            clients[6] = new Client { code = "C007", name = "Chris Evans", debt = 1200.0m, limitCredit = 6000.0m };
            clients[7] = new Client { code = "C008", name = "Laura Johnson", debt = 500.0m, limitCredit = 2500.0m };
            clients[8] = new Client { code = "C009", name = "Kevin Anderson", debt = 900.0m, limitCredit = 4500.0m };
            totalClients = 9;
        }

        public void GetClientSortByCodeAsc()
        {
            if (totalClients <= 1) return;  

            for (int i = 0; i < totalClients - 1; i++)
            {
                for (int j = 0; j < totalClients - i - 1; j++)
                {
                    if (clients[j].code.CompareTo(clients[j + 1].code) > 0)
                    { 
                        Client aux = clients[j];
                        clients[j] = clients[j + 1];
                        clients[j + 1] = aux;
                    }
                }
            }
        }

        public void GetClientSortByCodeDesc()
        {
            if (totalClients <= 1) return;

            for (int i = 0; i < totalClients - 1; i++)
            {
                for (int j = 0; j < totalClients - i - 1; j++)
                {
                    if (clients[j].code.CompareTo(clients[j + 1].code) < 0)
                    { 
                        Client aux = clients[j];
                        clients[j] = clients[j + 1];
                        clients[j + 1] = aux;
                    }
                }
            }
        }

        public void GetClientSortByNameAsc()
        {
            if (totalClients <= 1) return;

            for (int i = 0; i < totalClients - 1; i++)
            {
                for (int j = 0; j < totalClients - i - 1; j++)
                {
                    if (clients[j].name.CompareTo(clients[j + 1].name) > 0)
                    { 
                        Client aux = clients[j];
                        clients[j] = clients[j + 1];
                        clients[j + 1] = aux;
                    }
                }
            }
        }

        public void GetClientSortByNameDesc()
        {
            if (totalClients <= 1) return;

            for (int i = 0; i < totalClients - 1; i++)
            {
                for (int j = 0; j < totalClients - i - 1; j++)
                {
                    if (clients[j].name.CompareTo(clients[j + 1].name) < 0)
                    { 
                        Client aux = clients[j];
                        clients[j] = clients[j + 1];
                        clients[j + 1] = aux;
                    }
                }
            }
        }

        public void GetClientSortByDebtsAsc()
        {
            if (totalClients <= 1) return;

            for (int i = 0; i < totalClients - 1; i++)
            {
                for (int j = 0; j < totalClients - 1 - i; j++)
                {
                    if (clients[j].debt > clients[j + 1].debt)
                    { 
                        Client aux = clients[j];
                        clients[j] = clients[j + 1];
                        clients[j + 1] = aux;
                    }
                }
            }
        }

        public void GetClientSortByDebtsDesc()
        {
            if (totalClients <= 1) return;

            for (int i = 0; i < totalClients - 1; i++)
            {
                for (int j = 0; j < totalClients - 1 - i; j++)
                {
                    if (clients[j].debt < clients[j + 1].debt)
                    { 
                        Client aux = clients[j];
                        clients[j] = clients[j + 1];
                        clients[j + 1] = aux;
                    }
                }
            }
        }

        public void GetClientSortByLimitCreditAsc()
        {
            if (totalClients <= 1) return;

            for (int i = 0; i < totalClients - 1; i++)
            {
                for (int j = 0; j < totalClients - 1 - i; j++)
                {
                    if (clients[j].limitCredit > clients[j + 1].limitCredit)
                    { 
                        Client aux = clients[j];
                        clients[j] = clients[j + 1];
                        clients[j + 1] = aux;
                    }
                }
            }
        }

        public void GetClientSortByLimitCreditDesc()
        {
            if (totalClients <= 1) return;

            for (int i = 0; i < totalClients - 1; i++)
            {
                for (int j = 0; j < totalClients - 1 - i; j++)
                {
                    if (clients[j].limitCredit < clients[j + 1].limitCredit)
                    {
                        // Intercambia los elementos
                        Client aux = clients[j];
                        clients[j] = clients[j + 1];
                        clients[j + 1] = aux;
                    }
                }
            }
        }


    }
}
