using ExampleWebEFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebEFCore.Components
{
    public class BusinessViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(BusinessModel business)
        {
            return View(business);
        }
    }
}
