using Buisness.Abstract;
using DataAcsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Concrete
{
    public class ProductManeger : IProductService
    {
        IProductDal _productDal;

        public ProductManeger(IProductDal productDal)
        {
           _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //İş kodları

            return _productDal.GetAll();
        }
    }
}
