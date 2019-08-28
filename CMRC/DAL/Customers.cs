using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;

namespace DAL
{
    public class Customers : ICustomers
    {
        public void Add(CMRC_Customers t)
        {
            CommerceEntities1 dc = new CommerceEntities1();
            dc.CMRC_Customers.Add(t);
            dc.SaveChanges();
        }

        public void Deleteid(int id)
        {
            CommerceEntities1 dc = new CommerceEntities1();
            var a = dc.CMRC_Customers.Find(id);
            dc.CMRC_Customers.Remove(a);
            dc.SaveChanges();
        }

        public void Edit(int id)
        {
            
        }

        public CMRC_Customers FindID(int id)
        {
            CommerceEntities1 dc = new CommerceEntities1();
            return (CMRC_Customers)dc.CMRC_Customers.Where(x => x.CustomerID == id);
        }

        public List<CMRC_Customers> GetAll()
        {
            CommerceEntities1 dc = new CommerceEntities1();
            return dc.CMRC_Customers.ToList();
        }
    }
}
