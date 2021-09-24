using Core.EntityFramework;
using DataAcsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcsess.Concrete.EntityFramework
{
    public class EfOrderDal:EfEntityRepositoryBase<Order, NortWindContext>, IOrderDal
    {
    }
}
