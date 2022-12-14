using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrate;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
        
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Messages.OrderSuccessful);
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete( order);
            return new SuccessResult(Messages.OrderRemoved);
        }

        public IDataResult<Order> Get(int id)
        {
            return new SuccessDataResult<Order>(_orderDal.Get(o=>o.OrderId==id),Messages.ListingSuccessful);
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(),Messages.ListingSuccessful);
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(Messages.UpateSuccessful);
        }
    }
}
