using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcsess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delate(Product product);
        List<Product> GetAllByCategory(int categoryId);
    }
}
