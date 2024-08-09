using ExampleWebEFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebEFCore.Components
{
    public class GridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(GridViewModel<object> gridViewModel)
        {
            return View(gridViewModel);
        }
    }
}
