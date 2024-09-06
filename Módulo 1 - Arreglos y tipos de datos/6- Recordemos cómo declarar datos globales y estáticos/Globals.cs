using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4__Listados_condicionados_y_búsqueda_de_datos
{
    internal class Globals
    {

        public struct Client
        {
            public string code;
            public string name;
            public decimal debt;
            public decimal limitCredit;
        }

        static public  int MAXIMUN_CLIENTS = 20;

        static public  Client[] clients = new Client[MAXIMUN_CLIENTS];

        static public  int totalClients = 0;
    }
}
