using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;

namespace BLL
{
    public class Category : ICategories
    {
        public void Add(CMRC_Categories t)
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

        public CMRC_Categories FindID(int id)
        {
            throw new NotImplementedException();
        }

        public List<CMRC_Categories> GetAll()
        {
            Model.CommerceEntities1 dc = new Model.CommerceEntities1();
            return dc.CMRC_Categories.ToList();
        }
    }
}
