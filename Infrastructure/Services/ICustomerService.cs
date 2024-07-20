using Infrastructure.Domain;
using Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface ICustomerService
    {
        Customer GetById(int id);
        IList<Customer> GetAll();
        Customer Add(CustomerDto customer);
        Customer Update(CustomerDto customer);
    }
}
