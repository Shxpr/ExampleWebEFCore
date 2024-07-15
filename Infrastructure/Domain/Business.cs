using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Domain
{
    public class Business
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public string Address { get; set; }
        public IList<Invoice> Invoices { get; set;}

    }
}
