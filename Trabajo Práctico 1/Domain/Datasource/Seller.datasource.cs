using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Trabajo_Práctico_1.Domain.Models.Seller;

namespace Trabajo_Práctico_1.Domain.Datasource
{
    internal class SellerDatasource
    {
        public const int MAXIMUN_SELLERS = 10000;

        static public SellerStruct[] sellers = new SellerStruct[MAXIMUN_SELLERS];

        static public int totalSellers = 0;

    }

}
