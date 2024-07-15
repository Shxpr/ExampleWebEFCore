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
        public string BusinessName { get; set; }        
        public string BusinessAddress { get; set; }
        public IList<Invoice> Invoices { get; set;}

    }
}
