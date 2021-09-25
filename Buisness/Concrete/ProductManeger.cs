using Buisness.Abstract;
using DataAcsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public List<Product> GetAllByCategory(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice>= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
