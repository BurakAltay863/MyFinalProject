using Core.DataAcsess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcsess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
