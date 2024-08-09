namespace ExampleWebEFCore.Models
{
    public class InvoiceModel
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public string Customer { get; set; }
        public string Business { get; set; }
    }
}
