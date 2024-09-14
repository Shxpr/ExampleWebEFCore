using ExampleWebEFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebEFCore.Components
{
    public class CustomerViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(CustomerModel customer)
        {
            return View(customer);
        }
    }
}
