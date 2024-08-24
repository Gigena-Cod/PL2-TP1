using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Método_de_burbuja_para_ordenar_datos_de_un_vector.Class
{
   internal class ClientService
    {

        public struct ClientRegistry
        {
            public string code;
            public string name;
            public decimal debt;
            public decimal limitCredit;
        }

       public  ClientRegistry[] clients = new ClientRegistry[100];
        
        public int totalRegistries = 0;

        public void loadMockClients()
        {
            clients[0] = new ClientRegistry { code = "C001", name = "John Doe", debt = 1000.0m, limitCredit = 5000.0m };
            clients[1] = new ClientRegistry { code = "C002", name = "Jane Smith", debt = 250.0m, limitCredit = 2000.0m };
            clients[2] = new ClientRegistry { code = "C003", name = "Michael Brown", debt = 1500.0m, limitCredit = 7000.0m };
            clients[3] = new ClientRegistry { code = "C004", name = "Emily Davis", debt = 300.0m, limitCredit = 1500.0m };
            clients[4] = new ClientRegistry { code = "C005", name = "David Wilson", debt = 800.0m, limitCredit = 4000.0m };
            clients[5] = new ClientRegistry { code = "C006", name = "Sarah Miller", debt = 450.0m, limitCredit = 3500.0m };
            clients[6] = new ClientRegistry { code = "C007", name = "Chris Evans", debt = 1200.0m, limitCredit = 6000.0m };
            clients[7] = new ClientRegistry { code = "C008", name = "Laura Johnson", debt = 500.0m, limitCredit = 2500.0m };
            clients[8] = new ClientRegistry { code = "C009", name = "Kevin Anderson", debt = 900.0m, limitCredit = 4500.0m };
            totalRegistries = 10;
        }

    }
}
