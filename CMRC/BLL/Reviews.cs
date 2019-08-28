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
            return CreatFactory.Reviews().GetReviewsByID(Pid);
        }
    }
}
