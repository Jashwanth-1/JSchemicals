using JSCdata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICustomerService
    {
        public IEnumerable<Customer> getCustomers();

        public string addCustomer(Customer customer);
    }
}
