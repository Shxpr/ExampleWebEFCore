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
            navModels = new List<NavModel>();
            navModels.Add(new NavModel
            {
                IsActive = false,
                IsHidden = false,
                Text = "Home"
            });
            
            navModels.Add(new NavModel
            {
                IsActive = false,
                IsHidden = false,
                Text = "Business"
            });

            navModels.Add(new NavModel
            {
                IsActive = false,
                IsHidden = false,
                Text = "Invoice"
            });

            navModels.Add(new NavModel
            {
                IsActive = false,
                IsHidden = false,
                Text = "Customer"
            });
        }

        public async Task<IViewComponentResult> InvokeAsync(List<NavModel> navModelsParam)
        {
            if (navModelsParam?.Count == 0) 
            {
                return View(navModels);
            }
            else
            {
                return View(navModelsParam);
            }
        }
    }
}
