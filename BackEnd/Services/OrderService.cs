using JSCdata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderService
    {

        private JSCDBContext _jscDB;
        public OrderService(JSCDBContext jscDb)
        {
            this._jscDB = jscDb;
        }
        public IEnumerable<Order> getOrders()
        {
            return _jscDB.Orders.ToList();
        }

        public string newOrder(Order order)
        {
            try
            {
                _jscDB.Orders.Add(order);
                _jscDB.SaveChanges();
                return "Added";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
