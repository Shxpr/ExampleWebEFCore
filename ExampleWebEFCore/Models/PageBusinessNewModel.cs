namespace ExampleWebEFCore.Models
{
    public class PageBusinessNewModel
    {
        public List<NavModel> navModels { get; set; } = new List<NavModel>();
        public BusinessModel business { get; set; } = new  BusinessModel();
    }
}
