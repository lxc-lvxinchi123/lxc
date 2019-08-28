using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;

namespace DAL
{
    public class ShoppingCart : IShoppingCart
    {
        public void Add(CMRC_ShoppingCart t)
        {
           
        }

        public void Deleteid(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id)
        {
            throw new NotImplementedException();
        }

        public CMRC_ShoppingCart FindID(int id)
        {
            throw new NotImplementedException();
        }

        public List<CMRC_ShoppingCart> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
