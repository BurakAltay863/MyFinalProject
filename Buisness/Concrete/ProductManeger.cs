using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManeger : IProductService
    {
        IProductDal _productDal;

        public ProductManeger(IProductDal productDal)
        {
           _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            //busines codes
            if (product.ProductName.Length<2)
            {
                //magic strings
                return new ErrorResult(Messages.ProductNameInvalid);
            }

            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            //İş kodları
            //if (DateTime.Now.Hour==22)
            //{
            //    return new ErrorDataResult<List<Product>>(Messages.MainTenanceTime);
            //}

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult <List<Product>> GetAllByCategory(int id)
        {
            return new SuccessDataResult<List<Product>> (_productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult <Product> GetById(int productId)
        {
            return new SuccessDataResult<Product> (_productDal.Get(p=>p.ProductId==productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>> (_productDal.GetAll(p => p.UnitPrice>= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            
            return new SuccessDataResult<List<ProductDetailDto>> (_productDal.GetProductDetails());
        }
    }
}
