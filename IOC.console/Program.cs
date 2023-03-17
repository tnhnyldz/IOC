using System;

namespace IOC.console
{
    public class Program
    {
        static void Main(string[] args)
        {
            BL bl = new BL(new DAL());
            BL bl1 = new BL(new OracleDAL());
            bl.GetProducts().ForEach(x =>
           {
               Console.WriteLine(x.Id);
               Console.WriteLine(x.Name);
               Console.WriteLine(x.Price);
               Console.WriteLine(x.Stock);
               Console.WriteLine("--------------");
           });
            Console.WriteLine("000000000000000");
            bl1.GetProducts().ForEach(x =>
            {
                Console.WriteLine(x.Id);
                Console.WriteLine(x.Name);
                Console.WriteLine(x.Price);
                Console.WriteLine(x.Stock);
                Console.WriteLine("--------------");
            });
        }
    }
}
