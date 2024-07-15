using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Dto
{
    public record CreateInvoiceDto
    {
        public string InvoiceNumber { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerAddress { get; set; }
    }
}
