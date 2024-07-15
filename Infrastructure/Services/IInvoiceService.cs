using Infrastructure.Domain;
using Infrastructure.Dto;


namespace Infrastructure.Services
{
    public interface IInvoiceService
    {
        Invoice GetById(int id);
        IList<Invoice> GetAll();
        Invoice Add(CreateInvoiceDto invoice);
        Invoice Update(UpdateInvoiceDto invoice);
    }
}
