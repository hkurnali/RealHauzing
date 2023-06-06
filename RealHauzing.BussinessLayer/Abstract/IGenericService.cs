using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHauzing.BussinessLayer.Abstract
{
    public interface IGenericService<T>where T : class
    {
        void TInsert(T t);
        void TUpdate(T t);
        void TDelete(T t);
        T TGetbyID(int id);
        List<T> TGetList();
    }
}
