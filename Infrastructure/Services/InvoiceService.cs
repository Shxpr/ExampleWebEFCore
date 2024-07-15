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
    public class InvoiceService : IInvoiceService
    {
        private readonly IRepository<Invoice> _invoiceRepository;

        public InvoiceService(IRepository<Invoice> repository)
        {
            _invoiceRepository = repository;
        }
        public Invoice Add(CreateInvoiceDto invoice)
        {
            _invoiceRepository.Add(new Invoice
            {
                CustomerId = invoice.CustomerId,
                CustomerAddress = invoice.CustomerAddress,
                InvoiceNumber = invoice.InvoiceNumber
            });

            return new Invoice
            {
                CustomerId = invoice.CustomerId,
                CustomerAddress = invoice.CustomerAddress,
                InvoiceNumber = invoice.InvoiceNumber,
            };
        }

        public IList<Invoice> GetAll()
        {
            return _invoiceRepository.GetAll();
        }

        public Invoice GetById(int id)
        {
            return _invoiceRepository.Get(id);
        }

        public Invoice Update(UpdateInvoiceDto invoice)
        {
            _invoiceRepository.Update(new Invoice
            {
                Customer = new Customer
                {
                    LastName = invoice.Customer.LastName,
                    Name = invoice.Customer.Name,
                },
                CustomerAddress = invoice.CustomerAddress,
                InvoiceNumber = invoice.InvoiceNumber,
            });
            return new Invoice
            {
                Customer = new Customer
                {
                    LastName = invoice.Customer.LastName,
                    Name = invoice.Customer.Name,
                },
                CustomerAddress = invoice.CustomerAddress,
                InvoiceNumber = invoice.InvoiceNumber,
            };
        }
    }
}
