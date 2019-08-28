using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IReviews:IBass<Model.CMRC_Reviews>
    {
        List<Model.CMRC_Reviews> GetReviewsByID(int Pid);
    }
}
