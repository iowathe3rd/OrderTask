using System;
using System.Collections.Generic;
using System.Linq;
using Order.Data;
using Order.Models.Domain;

namespace Order.Services
{
    public interface IOrderService
    {
        IEnumerable<Models.Domain.Order> GetAllOrders();
        Models.Domain.Order GetOrderById(Guid id);
        void CreateOrder(Models.Domain.Order order);
        void DeleteOrder(Guid id);
    }

   public class OrderService : IOrderService
    {
        private readonly OrderDbContext _dbContext;

        public OrderService(OrderDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Models.Domain.Order> GetAllOrders()
        {
            return _dbContext.Orders.ToList();
        }

        public Models.Domain.Order GetOrderById(Guid id)
        {
            return _dbContext.Orders.Find(id);
        }

        public void CreateOrder(Models.Domain.Order order)
        {
            order.Id = Guid.NewGuid();
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
        }

        public void DeleteOrder(Guid id)
        {
            var order = _dbContext.Orders.Find(id);
            if (order != null)
            {
                _dbContext.Orders.Remove(order);
                _dbContext.SaveChanges();
            }
        }
    }
}
