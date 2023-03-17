using System;

namespace IOC.console
{
    public class Program
    {
        static void Main(string[] args)
        {
            BL bl = new BL();
            bl.GetProducts().ForEach(x =>
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
