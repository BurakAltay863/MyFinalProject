﻿using Core.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfOrderDal:EfEntityRepositoryBase<Order, NortWindContext>, IOrderDal
    {
    }
}
