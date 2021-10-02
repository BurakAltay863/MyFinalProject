using Core.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.EntityFramework
{
    //NuGet
    public class EfProductDal : EfEntityRepositoryBase<Product, NortWindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using NortWindContext context = new NortWindContext();

            var result = from p in context.Products
                         join c in context.Categories
                         on p.CategoryId equals c.CategoryId
                         select new ProductDetailDto
                         {
                             ProductId = p.ProductId,
                             ProductName = p.ProductName,
                             CategoryName = c.CategoryName,
                             UnitsInStock = p.UnitsInStock
                         };
            return result.ToList();
        }
    }
}
