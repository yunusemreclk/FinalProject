﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Messages.OrderAdded);
        }

        public IResult Delete(Order order)
        {
           _orderDal.Delete(order);
            return new SuccessResult(Messages.OrderDeleted);
        }

        public IDataResult<List<Order>> GetAll()
        {
            _orderDal.GetAll();
            return new SuccessDataResult<List<Order>>(Messages.OrderListed);
        }

        public IDataResult<Order> GetById(int orderId)
        {
           return new SuccessDataResult<Order>(_orderDal.Get(o=>o.OrderID==orderId));
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(Messages.OrderUpdated);
        }
    }
}
