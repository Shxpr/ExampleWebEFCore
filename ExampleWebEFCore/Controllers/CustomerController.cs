using ExampleWebEFCore.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebEFCore.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IActionResult Index()
        {
            PageCustomerModel model = new PageCustomerModel();
            GridViewModel<object> customerGv = new GridViewModel<object>();
            customerGv.Columns = new List<string>();
            customerGv.StyleHeader = "table table-striped table-bordered";
            customerGv.Columns.Add("Id");
            customerGv.Columns.Add("Name");
            customerGv.Columns.Add("Last Name");
            customerGv.Columns.Add("");
            var data = new List<CustomerModel>();
            var entityData = _customerService.GetAll();
            List<ButtonModel> buttonModels = new List<ButtonModel>();
            buttonModels.Add(new ButtonModel { Text = "Edit", Action = "Edit", Controller = "Customer", StyleButton = EnumButtonCss.Default });
            buttonModels.Add(new ButtonModel { Text = "Del", Action = "Del", Controller = "Customer", StyleButton = EnumButtonCss.Danger });
            foreach (var item in entityData)
            {
                data.Add(new CustomerModel { Id = item.Id, LastName = item.LastName, Name = item.Name, Buttons = buttonModels });
            }

            customerGv.Data = data.Cast<object>().ToList();

            model.CustomerGv = customerGv;
            return View(model);
        }
        public IActionResult New()
        {
            var model = new PageCustomerNewModel();
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
                Text = "Customer"
            });

            model.navModels.Add(new NavModel
            {
                IsActive = true,
                IsHidden = false,
                Text = "New Customer"
            });
            
            return View(model);
        }

        [HttpPost]
        public IActionResult New(CustomerModel customer) 
        {
            var item = _customerService.Add(new Infrastructure.Dto.CustomerDto { Name = customer.Name, LastName = customer.LastName });

                return RedirectToAction("Index");
        }
    }
}
