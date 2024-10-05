namespace ExampleWebEFCore.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<ButtonModel> Buttons { get; set; } = new List<ButtonModel>();
    }
}
