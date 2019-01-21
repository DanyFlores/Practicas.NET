using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeClientes
{
    public class CustomerManager
    {
        public CustomerManager()
        {
            _Customer = new List<Customer>();
        }
        private List<Customer> _Customer ;

        public List<Customer> Customers
        {
            get
            {
                return _Customer;
            }
        }

        public void AddCustomer(string name, string lastname, string address)
        {
            Customer newcustomer = new Customer()
            {
                Name = name,
                LastName = lastname,                
                Address = address
            };
            _Customer.Add(newcustomer);
        }
    }
}
