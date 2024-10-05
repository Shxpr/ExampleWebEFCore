using ExampleWebEFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Logging;

namespace ExampleWebEFCore.Components
{
    public class NavViewComponent : ViewComponent
    {
        List<NavModel> navModels;
        public NavViewComponent()
        {
            
        }

        public async Task<IViewComponentResult> InvokeAsync(List<NavModel> navModelsParam)
        {
             return View(navModelsParam);            
        }
    }
}
