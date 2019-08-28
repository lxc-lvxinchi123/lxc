using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;

namespace DAL
{
    public class Reviews : IReviews
    {
        public void Add(CMRC_Reviews t)
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

        public CMRC_Reviews FindID(int id)
        {
            throw new NotImplementedException();
        }

        public List<CMRC_Reviews> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<CMRC_Reviews> GetReviewsByID(int Pid)
        {
            Model.CommerceEntities1 dc = new Model.CommerceEntities1();
            return dc.CMRC_Reviews.Where(x => x.ProductID == Pid).ToList();
        }
    }
}
