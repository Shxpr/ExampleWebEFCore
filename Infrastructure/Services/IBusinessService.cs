using Infrastructure.Domain;
using Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface IBusinessService
    {
        Business GetById(int id);
        IList<Business> GetAll();
        Business Add(CreateBusinessDto business);
        Business Update(UpdateBusinessDto business);
    }
}

