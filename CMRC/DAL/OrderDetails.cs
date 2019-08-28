using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;

namespace DAL
{
    public class OrderDetails : IOrderDetails
    {
        public void Add(CMRC_OrderDetails t)
        {
            CommerceEntities1 dc = new CommerceEntities1();
            dc.CMRC_OrderDetails.Add(t);
            dc.SaveChanges();
        }

        public void Deleteid(int id)
        {
            CommerceEntities1 dc = new CommerceEntities1();
            var a = dc.CMRC_OrderDetails.Find(id);
            dc.CMRC_OrderDetails.Remove(a);
            dc.SaveChanges();
        }

        public void Edit(int id)
        {
           
        }

        public CMRC_OrderDetails FindID(int id)
        {
            throw new NotImplementedException();
        }

        public List<CMRC_OrderDetails> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
