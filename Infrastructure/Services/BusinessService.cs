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
    public class BusinessService : IBusinessService
    {
        private readonly IRepository<Business> _businessRepository;
        public BusinessService(IRepository<Business> repository)
        {
            _businessRepository = repository;
        }
        public Business Add(CreateBusinessDto business)
        {
            _businessRepository.Add(new Business
            {                
                Name = business.Name,
                Address = business.Address,                
            });

            return new Business
            {
                Name = business.Name,
                Address = business.Address,
            };
        }        

        public IList<Business> GetAll()
        {
            return _businessRepository.GetAll();            
        }

        public Business GetById(int id)
        {
            return _businessRepository.Get(id);
        }

        public Business Update(UpdateBusinessDto business)
        {
            _businessRepository.Update(new Business
            {
                Name = business.Name,
                Address = business.Address,
            });

            return new Business
            {
                Name = business.Name,
                Address = business.Address,
            };

        }
    }
}
