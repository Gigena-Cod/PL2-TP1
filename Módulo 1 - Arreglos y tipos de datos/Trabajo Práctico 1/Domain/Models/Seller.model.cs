using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Trabajo_Práctico_1.Domain.Models
{
    internal class Seller
    {
        public struct SellerStruct
        {
            public int code { get; }
            public string name { get; }
            public decimal salary { get; }

            public SellerStruct(int code, string name, decimal salary)
            {
                this.code = code;
                this.name = name;
                this.salary = salary;
            }
        }


        static public SellerStruct createSeller(int code, string name, decimal salary)
        { 

            return new SellerStruct(code, name, salary);
        }
    }
}
