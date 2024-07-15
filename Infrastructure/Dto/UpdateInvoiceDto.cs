using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Dto
{
    public record UpdateInvoiceDto
    {
        public string InvoiceNumber { get; set; }
        public string CustomerAddress { get; set;}
        public CustomerDto Customer { get; set;}
    }
}
