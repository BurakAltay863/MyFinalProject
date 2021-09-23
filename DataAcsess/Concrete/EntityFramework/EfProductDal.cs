using DataAcsess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcsess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        //NuGet
        public void Add(Product entity)
        {
            //IDisposble pattern implementation of c#
            using (NortWindContext context=new NortWindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delate(Product entity)
        {
            using (NortWindContext context = new NortWindContext())
            {
                var deletededEntity = context.Entry(entity);
                deletededEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using NortWindContext context = new NortWindContext();
            return context.Set<Product>().SingleOrDefault(filter);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using NortWindContext context = new NortWindContext();
            return filter == null
                ? context.Set<Product>().ToList()
                :context.Set<Product>().Where(filter).ToList();
        }

        public void Update(Product entity)
        {
            using NortWindContext context = new NortWindContext();
            var updatededEntity = context.Entry(entity);
            updatededEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
