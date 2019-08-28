using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;

namespace DAL
{
    public class Products : IProducts
    {
        public void Add(CMRC_Products t)
        {
            throw new NotImplementedException();
        }

        public void Deleteid(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id)
        {
            throw new NotImplementedException();
        }

        public CMRC_Products FindID(int id)
        {

            Model.CommerceEntities1 dc = new Model.CommerceEntities1();
            return dc.CMRC_Products.Find(id);
        }

        public List<CMRC_Products> GetAll()
        {
            throw new NotImplementedException();
        }

       

        

        

        

        List<CMRC_Products> IProducts.GetAllID(int id)
        {
           
            CommerceEntities1 dc = new CommerceEntities1();
            return dc.CMRC_Products.Where(x => x.CategoryID == id).ToList();
        }
    }
}
