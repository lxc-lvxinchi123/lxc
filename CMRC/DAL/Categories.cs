using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAL;

namespace DAL
{
    public class Categories : ICategories
    {
        public void Add(CMRC_Categories t)
        {
            CommerceEntities1 dc = new CommerceEntities1();
            dc.CMRC_Categories.Add(t);
            dc.SaveChanges();
        }

        public void Deleteid(int id)
        {
            CommerceEntities1 dc = new CommerceEntities1();
            var a = dc.CMRC_Categories.Find(id);
            dc.CMRC_Categories.Remove(a);
            dc.SaveChanges();
        }

        public void Edit(int id)
        {
            
        }

        public CMRC_Categories FindID(int id)
        {
            CommerceEntities1 dc = new CommerceEntities1();
            return (CMRC_Categories)dc.CMRC_Categories.Where(x => x.CategoryID == id);
        }

        public List<CMRC_Categories> GetAll()
        {
            CommerceEntities1 dc = new CommerceEntities1();
            return dc.CMRC_Categories.ToList();
        }
    }
}
