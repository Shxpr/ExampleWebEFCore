using ExampleWebEFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebEFCore.Components
{
    public class GvButtonViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(List<ButtonModel> buttonModels)
        {
            return View(buttonModels);
        }
    }
}
