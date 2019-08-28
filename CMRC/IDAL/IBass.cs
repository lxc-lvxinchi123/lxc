using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
  public interface IBass<T>
    {
        List<T>GetAll();
        void Add(T t);
        void Deleteid(int id);
        void Edit(int id);
        T FindID(int id);
    }
}
