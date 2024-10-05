using ExampleWebEFCore.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebEFCore.Controllers
{
    public class BusinessController : Controller
    {
        private readonly IBusinessService _businessService;
        public BusinessController(IBusinessService businessService)
        {
            _businessService = businessService;
        }
        public IActionResult Index()
        {
            PageBusinessModel model = new PageBusinessModel();
            GridViewModel<object> businessGv = new GridViewModel<object>();
            businessGv.Columns = new List<string>();
            businessGv.StyleHeader = "table table-striped table-bordered";
            businessGv.Columns.Add("Id");
            businessGv.Columns.Add("Name");
            businessGv.Columns.Add("Address");
            businessGv.Columns.Add("Address");
            var data = new List<BusinessModel>();
            var entityData = _businessService.GetAll();
            List<ButtonModel> buttonModels = new List<ButtonModel>();
            buttonModels.Add(new ButtonModel { Text = "Edit", Action = "Edit", Controller = "Business", StyleButton = EnumButtonCss.Default });
            buttonModels.Add(new ButtonModel { Text = "Del", Action = "Del", Controller = "Business", StyleButton = EnumButtonCss.Danger });
            foreach (var item in entityData)
            {
                data.Add(new BusinessModel { Id = item.Id, Address = item.Address, Name = item.Name });
            }

            businessGv.Data = data.Cast<object>().ToList();

            model.BusinessGv = businessGv;
            return View(model);
        }
        public IActionResult New()
        {
            var model = new PageBusinessNewModel();
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
                Text = "Business"
            });

            model.navModels.Add(new NavModel
            {
                IsActive = true,
                IsHidden = false,
                Text = "New Business"
            });

            return View(model);
        }

        [HttpPost]
        public IActionResult New(BusinessModel business)
        {
            var item = _businessService.Add(new Infrastructure.Dto.CreateBusinessDto { Name = business.Name, Address = business.Address });

            return RedirectToAction("Index");
        }
    }
}
