using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.console
{
    public class BL
    {
        //Bl içinde başka classlar newledik ve bu da 
        //bir bağımlılık oluşturdu.
        //DAL metotlarından herhangı bırısının ısmı degısırse veya
        //bir degısıklık olursa bu buradakı elemanlarına da yansıyacak
        //ve bunu ıstemıyoruz. Burada tightly coupled bir kod var
        private DAL _dal { get; set; }

        public BL()
        {
            _dal = new DAL();
        }
        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
