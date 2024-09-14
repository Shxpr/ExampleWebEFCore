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
            return View();
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
            if (customer.Id == 0) 
            {
                return RedirectToAction("Index");
            }

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
            
            return View();
        }
    }
}
