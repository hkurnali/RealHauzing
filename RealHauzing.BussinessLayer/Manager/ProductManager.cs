using RealHauzing.BussinessLayer.Abstract;
using RealHauzing.DataAccessLayer.Abstract;
using RealHauzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHauzing.BussinessLayer.Manager
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product t)
        {
           _productDal.Delete(t);
        }

        public Product TGetbyID(int id)
        {
          return _productDal.GetbyID(id);
        }

        public List<Product> TGetList()
        {
           return _productDal.GetList();
        }

        public void TInsert(Product t)
        {
           _productDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
