using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.console
{
    public class OracleDAL : IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product> {
               new Product{Id= 1,Name="Oracle Kalem 1",Price=100,Stock=200},
               new Product{Id= 2,Name="Oracle Kalem 2",Price=100,Stock=200},
               new Product{Id= 3,Name="Oracle Kalem 3",Price=100,Stock=200},
               new Product{Id= 4,Name="Oracle Kalem 4",Price=100,Stock=200}
            };
        }
    }
}
