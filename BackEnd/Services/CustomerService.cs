using JSCdata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private JSCDBContext _jscDB;
        public CustomerService(JSCDBContext jscDb)
        {
            this._jscDB = jscDb;
        }
        public IEnumerable<Customer> getCustomers()
        {
            return _jscDB.Customers.ToList();
        }

        public string addCustomer(Customer customer)
        {
            try
            {
                _jscDB.Customers.Add(customer);
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
