using ExampleWebEFCore.Models;
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
                PageInvoiceModel model = new PageInvoiceModel();
                GridViewModel<object> invoiceGv = new GridViewModel<object>();
                invoiceGv.Columns = new List<string>();
                invoiceGv.StyleHeader = "table table-striped table-bordered";
                invoiceGv.Columns.Add("Id");
                invoiceGv.Columns.Add("Invoice Number");
                invoiceGv.Columns.Add("Customer");
                invoiceGv.Columns.Add("Business");
                var data = new List<InvoiceModel>();
                var entityData = _invoiceService.GetAll();
                foreach (var item in entityData)
                {
                    data.Add(new InvoiceModel { Id = item.Id, InvoiceNumber = item.InvoiceNumber, Customer = item.Customer.Name, Business = item.Business.Name });
                }

                invoiceGv.Data = data.Cast<object>().ToList();

                model.InvoiceGv = invoiceGv;
                return View(model);
        }
            public IActionResult New()
            {
                var model = new PageInvoiceNewModel();
                model.navModels.Add(new NavModel
                {
                    IsActive = false,
                    IsHidden = false,
                    Text = "Home"
                });

                model.navModels.Add(new NavModel
                {
                    IsActive = false,
                    IsHidden = false,
                    Text = "Invoice"
                });

                model.navModels.Add(new NavModel
                {
                    IsActive = true,
                    IsHidden = false,
                    Text = "New Invoice"
                });

                return View(model);
            }

            [HttpPost]
            public IActionResult New(InvoiceModel invoice)
            {
                if (invoice.Id == 0)
                {
                    return RedirectToAction("Index");
                }

                var model = new PageInvoiceNewModel();
                model.navModels.Add(new NavModel
                {
                    IsActive = false,
                    IsHidden = false,
                    Text = "Home"
                });

                model.navModels.Add(new NavModel
                {
                    IsActive = false,
                    IsHidden = false,
                    Text = "Invoice"
                });

                model.navModels.Add(new NavModel
                {
                    IsActive = true,
                    IsHidden = false,
                    Text = "New Invoice"
                });
                return View();
            }
    }
}

