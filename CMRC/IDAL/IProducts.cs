using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IProducts:IBass<Model.CMRC_Products>
    {
        List<Model.CMRC_Products> GetAllID(int id);
    }
}
