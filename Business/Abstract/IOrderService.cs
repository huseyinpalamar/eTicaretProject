﻿using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> Get(int id);
        IResult Add(Order order);
        IResult Update(Order order);   
        IResult Delete(Order order);

         
            
    }
}
