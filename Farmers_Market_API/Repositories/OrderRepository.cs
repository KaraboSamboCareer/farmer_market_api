using Farmers_Market_API.Interfaces;
using Farmers_Market_API.Models;
using Farmers_Market_API.Exceptions;

namespace Farmers_Market_API.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private List<Order> Orders = new List<Order>();


        public Order Add(Order order)
        {
            Orders.Add(order);
            return order;
        }

        public Order Delete(Order order)
        {
            var foundOrder = Orders.FirstOrDefault(o => o.Id == order.Id, null);
            if(foundOrder == null) { throw new OrderNotFoundException(order.Id); }

            Orders.Remove(foundOrder);
            return order;
        }

        public List<Order> GetAll()
        {
            return Orders;
        }

        public Order GetById(int id)
        {
            var foundOrder = Orders.FirstOrDefault(o => o.Id == id, null);
            return foundOrder ?? throw new OrderNotFoundException(id);
        }

        public Order Update(Order entity)
        {
            var foundOrder = Orders.FirstOrDefault(o => o.Id == entity.Id, null);
            if(foundOrder == null) { throw new OrderNotFoundException(entity.Id); }

            foundOrder.BuyerId = entity.BuyerId;
            foundOrder.ListingId = entity.ListingId;
            foundOrder.QuantityOrdered = entity.QuantityOrdered;
            foundOrder.TotalPrice = entity.TotalPrice;
            foundOrder.Status = entity.Status;
            foundOrder.OrderDate = entity.OrderDate;
            foundOrder.CollectionDate = entity.CollectionDate;
            foundOrder.Notes = entity.Notes;
            return foundOrder;
        }
    }
}
