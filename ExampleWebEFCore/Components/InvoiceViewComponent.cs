using ExampleWebEFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebEFCore.Components
{
    public class InvoiceViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(InvoiceModel invoice)
        {
            return View(invoice);
        }
    }
}
