using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.console
{
    public class BL
    {
        private IDAL _dal { get; set; }

        public BL()
        {
            //BL artık dal hakkında hıcbır bılgı sahıbı degıl
            //sadece lazım olan metotlara erısebılıyor yanı soyutlandı
            _dal = DALFactory.GetDAL();
        }
        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
