namespace ExampleWebEFCore.Models
{
    public class PageCustomerNewModel
    {
        public List<NavModel> navModels { get; set; } = new List<NavModel>();
        public CustomerModel customer { get; set; } = new CustomerModel();
    }
}
