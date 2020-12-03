using LiveInCircle.BLL.Abstract;
using LiveInCircle.DAL.Abstract;
using LiveInCircle.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveInCircle.BLL.Concrete
{
    class OrderService : IOrderBLL
    {
        IOrderDAL orderDAL;
        public OrderService(IOrderDAL dal)
        {
            orderDAL = dal;
        }
        void Check(Order order)
        {
            if (order.OrderDate < DateTime.Now)
            {
                throw new Exception("Sipariş tarihi bugünün tarihinden sonra olmalıdır.");
            }
        }
        public void Insert(Order entity)
        {
            Check(entity);
            orderDAL.Add(entity);
        }

        public void Update(Order entity)
        {
            Check(entity);
            orderDAL.Update(entity);
        }
        public void Delete(Order entity)
        {
            entity.IsActive = false;
            orderDAL.Update(entity);
        }

        public void DeleteByID(int entityID)
        {
            Order order = Get(entityID);
            order.IsActive = false;
            orderDAL.Update(order);
        }

        public Order Get(int entityID)
        {
            return orderDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Order> GetAll()
        {
            return orderDAL.GetAll();
        }


    }
}
