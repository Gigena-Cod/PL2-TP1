using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_Práctico_1.Domain.Datasource;
using Trabajo_Práctico_1.Domain.Models; 

namespace Trabajo_Práctico_1.Domain.Service
{
    internal class SellerService
    {

        public  async Task<bool> CreateSellerAsync(int code, string name, decimal salary )
        {
            try {
                await Task.Delay(2000);

                if (SellerDatasource.totalSellers >= SellerDatasource.MAXIMUN_SELLERS)
                {
                    MessageBox.Show("Has alcanzado el máximo número de vendedores", "Límite de Vendedores",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                //throw new InvalidOperationException("Error simulado para pruebas.");

                Seller.SellerStruct newSeller = Seller.createSeller(code, name, salary);

                SellerDatasource.sellers[SellerDatasource.totalSellers] = newSeller;

                SellerDatasource.totalSellers++;
                return true;
            }
            catch (Exception ex)
            {

                return false;
                
            }

        }
    }
}
