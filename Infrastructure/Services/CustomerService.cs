using Infrastructure.Domain;
using Infrastructure.Dto;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _customerRepository;
        public CustomerService(IRepository<Customer> repository)
        {
            _customerRepository = repository;
        }
        public Customer Add(CustomerDto customer)
        {
            _customerRepository.Add(new Customer
            {
                Name = customer.Name,
                LastName = customer.LastName,
            });

            return new Customer
            {
                Name = customer.Name,
                LastName = customer.LastName,
            };
        }

        public IList<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetById(int id)
        {
            return _customerRepository.Get(id);
        }

        public Customer Update(CustomerDto customer)
        {
            _customerRepository.Update(new Customer
            {
                Name = customer.Name,
                LastName = customer.LastName,
            });

            return new Customer
            {
                Name = customer.Name,
                LastName = customer.LastName,
            };

        }
    }
}
