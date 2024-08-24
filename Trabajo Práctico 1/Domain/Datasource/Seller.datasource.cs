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

        static public void LoadMock()
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

        static public SellerStruct[] SortByCodeAscSellers() {

            if(totalSellers == 0) return Array.Empty<SellerStruct>();

            for (int i=0; i < totalSellers - 1;i++)
            {
                for (int j=0; j < totalSellers - 1 - i; j++){
                    if (sellers[j].code.CompareTo(sellers[j+1].code)>0)
                    {
                        SellerStruct sellerStruct = sellers[j];
                        sellers[j] = sellers[j + 1];
                        sellers[j + 1] = sellerStruct;
                    }
                }
            }

            return sellers;
        }

        static public SellerStruct[] SortByCodeDescSellers()
        {

            if (totalSellers == 0) return Array.Empty<SellerStruct>();

            for (int i = 0; i < totalSellers - 1; i++)
            {
                for (int j = 0; j < totalSellers - 1 - i; j++)
                {
                    if (sellers[j].code.CompareTo(sellers[j + 1].code) < 0)
                    {
                        SellerStruct sellerStruct = sellers[j];
                        sellers[j] = sellers[j + 1];
                        sellers[j + 1] = sellerStruct;
                    }
                }
            }

            return sellers;
        }

        static public SellerStruct[] SortByNameAscSellers()
        {

            if (totalSellers == 0) return Array.Empty<SellerStruct>();

            for (int i = 0; i < totalSellers - 1; i++)
            {
                for (int j = 0; j < totalSellers - 1 - i; j++)
                {
                    if (sellers[j].name.CompareTo(sellers[j + 1].name) > 0)
                    {
                        SellerStruct sellerStruct = sellers[j];
                        sellers[j] = sellers[j + 1];
                        sellers[j + 1] = sellerStruct;
                    }
                }
            }

            return sellers;
        }

        static public SellerStruct[] SortByNameDescSellers()
        {

            if (totalSellers == 0) return Array.Empty<SellerStruct>();

            for (int i = 0; i < totalSellers - 1; i++)
            {
                for (int j = 0; j < totalSellers - 1 - i; j++)
                {
                    if (sellers[j].name.CompareTo(sellers[j + 1].name) < 0)
                    {
                        SellerStruct sellerStruct = sellers[j];
                        sellers[j] = sellers[j + 1];
                        sellers[j + 1] = sellerStruct;
                    }
                }
            }

            return sellers;
        }

        static public SellerStruct[] SortBySalaryAscSellers()
        {

            if (totalSellers == 0) return Array.Empty<SellerStruct>();

            for (int i = 0; i < totalSellers - 1; i++)
            {
                for (int j = 0; j < totalSellers - 1 - i; j++)
                {
                    if (sellers[j].salary>sellers[j + 1].salary)
                    {
                        SellerStruct sellerStruct = sellers[j];
                        sellers[j] = sellers[j + 1];
                        sellers[j + 1] = sellerStruct;
                    }
                }
            }

            return sellers;
        }

        static public SellerStruct[] SortBySalaryDescSellers()
        {

            if (totalSellers == 0) return Array.Empty<SellerStruct>();

            for (int i = 0; i < totalSellers - 1; i++)
            {
                for (int j = 0; j < totalSellers - 1 - i; j++)
                {
                    if (sellers[j].salary < sellers[j + 1].salary)
                        {
                        SellerStruct sellerStruct = sellers[j];
                        sellers[j] = sellers[j + 1];
                        sellers[j + 1] = sellerStruct;
                    }
                }
            }

            return sellers;
        }
    }

}
