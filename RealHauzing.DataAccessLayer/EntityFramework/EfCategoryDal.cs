using RealHauzing.DataAccessLayer.Abstract;
using RealHauzing.DataAccessLayer.Concrete;
using RealHauzing.DataAccessLayer.Repository;
using RealHauzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHauzing.DataAccessLayer.EntityFramework
{
   public  class EfCategoryDal:GenericRepository<Category>,ICategoryDal
    {
        public EfCategoryDal(Context context) : base(context)
        {


        }
    }
}
