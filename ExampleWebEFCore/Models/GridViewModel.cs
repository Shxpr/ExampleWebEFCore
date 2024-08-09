namespace ExampleWebEFCore.Models
{
    public class GridViewModel<T>
    {
        public string StyleHeader { get; set; }
        public List<string> Columns { get; set; }
        public List<T> Data { get; set; }
    }
}
