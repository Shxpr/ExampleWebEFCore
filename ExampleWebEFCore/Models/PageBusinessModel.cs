namespace ExampleWebEFCore.Models
{
    public class PageBusinessModel
    {
        public List<NavModel> NavModels { get; set; } = new List<NavModel>();
        public GridViewModel<object> BusinessGv { get; set; } = new GridViewModel<object>();
        public List<ButtonModel> ButtonModels { get; set; } = new List<ButtonModel>();

        public PageBusinessModel()
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
                Text = "Name"
            });

            NavModels.Add(new NavModel
            {
                IsActive = false,
                IsHidden = true,
                Text = "Address"
            });
            
            ButtonModels.Add(new ButtonModel { Action = "New", Controller = "Business", StyleButton = EnumButtonCss.Success, Text = "New Business" });
            ButtonModels.Add(new ButtonModel { Action = "Delete", Controller = "Business", StyleButton = EnumButtonCss.Danger, Text = "Delete Business" });
        }
    }
}
