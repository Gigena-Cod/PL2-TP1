using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_Práctico_1.Domain.Models;
using static Trabajo_Práctico_1.Domain.Models.Seller;

namespace Trabajo_Práctico_1.Domain.Datasource
{
    internal class SellerDatasource
    {
        public const int MAXIMUN_SELLERS = 10000;

        static public SellerStruct[] sellers = new SellerStruct[MAXIMUN_SELLERS];

        static public int totalSellers = 0;

        public void LoadMock()
        {
            SellerStruct[] mockSellers = [ 
                createSeller(1, "Ana Martínez", 1500.00m),
                createSeller(2, "Luis Gómez", 1600.00m),
                createSeller(3, "Carlos Fernández", 1700.00m),
                createSeller(4, "Marta Sánchez", 1800.00m),
                createSeller(5, "Pedro Ruiz", 1900.00m),
                createSeller(6, "Laura Pérez", 2000.00m),
                createSeller(7, "Jorge Díaz", 2100.00m),
                createSeller(8, "Elena López", 2200.00m),
                createSeller(9, "Francisco Moreno", 2300.00m),
                createSeller(10, "Isabel Ortega", 2400.00m),
                createSeller(11, "Fernando Castro", 2500.00m),
                createSeller(12, "Raquel Romero", 2600.00m),
                createSeller(13, "Andrés Vargas", 2700.00m),
                createSeller(14, "Patricia González", 2800.00m),
                createSeller(15, "Ricardo Martínez", 2900.00m)
            ];
            
             
            for(int i = 0; i < 15; i++)
            {
                sellers[i] = mockSellers[i];
            }

            totalSellers = mockSellers.Length;
        }

    }

}
