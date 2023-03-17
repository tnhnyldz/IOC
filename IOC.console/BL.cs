﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.console
{
    public class BL
    {
        private DAL _dal { get; set; }

        public BL()
        {
            //Bl Dal kısmını artık dısarıdan alacak
            _dal = DALFactory.GetDAL();
        }
        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
