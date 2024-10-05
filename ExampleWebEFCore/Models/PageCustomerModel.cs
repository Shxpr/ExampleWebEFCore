namespace ExampleWebEFCore.Models
{
    public class PageCustomerModel
    {
        public List<NavModel> NavModels { get; set; } = new List<NavModel>();
        public GridViewModel<object> CustomerGv { get; set; } = new GridViewModel<object>();
        public List<ButtonModel> ButtonModels { get; set; } = new List<ButtonModel>();

        public PageCustomerModel()
        {
            NavModels.Add(new NavModel
            {
                IsActive = false,
                IsHidden = false,
                Text = "Home"
            });

            NavModels.Add(new NavModel
            {
                IsActive = false,
                IsHidden = true,
                Text = "Business"
            });

            NavModels.Add(new NavModel
            {
                IsActive = false,
                IsHidden = true,
                Text = "Invoice"
            });

            NavModels.Add(new NavModel
            {
                IsActive = true,
                IsHidden = false,
                Text = "Customer"
            });
            ButtonModels.Add(new ButtonModel { Action = "New", Controller = "Customer", StyleButton = EnumButtonCss.Success, Text = "New Customer" });
            ButtonModels.Add(new ButtonModel { Action = "Delete", Controller = "Customer", StyleButton = EnumButtonCss.Danger, Text = "Delete Customer" });

            //GridViewModel<object> customerGv = new GridViewModel<object>();
            //customerGv.Columns = new List<string>();
            //customerGv.StyleHeader = "table table-striped table-bordered";
            //customerGv.Columns.Add("Id");
            //customerGv.Columns.Add("Name");
            //customerGv.Columns.Add("Last Name");
            //var data = new List<CustomerModel>();
            //data.Add(new CustomerModel { Id = 1, Name = "Test 1", LastName = "Test 1" });
            //data.Add(new CustomerModel { Id = 2, Name = "Test 2", LastName = "Test 2" });
            //data.Add(new CustomerModel { Id = 3, Name = "Test 3", LastName = "Test 3" });
            //customerGv.Data = data.Cast<object>().ToList();
        }
    }
}
