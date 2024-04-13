using GoCompareShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCompareShop.CustomerService.Interface
{
    public interface ICustomerInterface
    {
        List<Customer> GetAll();

        Customer GetCustomerById(int id);

        ErrorObject Add(Customer customer);

        ErrorObject Update(Customer customer);

        ErrorObject Delete(int customerId);

    }
}
