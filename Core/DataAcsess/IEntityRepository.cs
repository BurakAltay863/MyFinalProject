using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAcsess
{
    //generic constraint
    // referans tip
    //IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() newlenebilir olamlı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delate(T entity);
      
    }
}
