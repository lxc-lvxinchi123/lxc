using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;
using Factory;



namespace BLL
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
            return CreatFactory.Products().FindID(id);
        }

        public List<CMRC_Products> GetAll()
        {
            return CreatFactory.Products().GetAll();
        }

        public IList<CMRC_Products> GetAllID(int id)
        {
            return CreatFactory.Products().GetAllID(id);
            
        }

        List<CMRC_Products> IProducts.GetAllID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
