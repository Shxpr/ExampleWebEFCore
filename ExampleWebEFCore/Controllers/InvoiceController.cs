using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebEFCore.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService _invoiceService;
        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
