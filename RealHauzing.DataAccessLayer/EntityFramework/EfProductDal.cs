using Microsoft.EntityFrameworkCore;
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
    
        public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(Context context) : base(context)
        {


        }

        public List<Product> GetProductWithCategories()
        {
            var context=new Context();
            var values=context.Products.Include(p => p.Category).ToList();
            return values;
        }
    }
    
}
