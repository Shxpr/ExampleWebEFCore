namespace ExampleWebEFCore.Models
{
    public class PageInvoiceNewModel
    {
        public List<NavModel> navModels { get; set; } = new List<NavModel>();
        public InvoiceModel invoice { get; set; } = new InvoiceModel();
    }
}
