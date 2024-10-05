namespace ExampleWebEFCore.Models
{
    public class PageInvoiceModel
    {
        public List<NavModel> NavModels { get; set; } = new List<NavModel>();
        public GridViewModel<object> InvoiceGv { get; set; } = new GridViewModel<object>();
        public List<ButtonModel> ButtonModels { get; set; } = new List<ButtonModel>();

        public PageInvoiceModel()
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
                Text = "Invoice Number"
            });

            NavModels.Add(new NavModel
            {
                IsActive = false,
                IsHidden = true,
                Text = "Customer"
            });

            NavModels.Add(new NavModel
            {
                IsActive = true,
                IsHidden = false,
                Text = "Business"
            });
            ButtonModels.Add(new ButtonModel { Action = "New", Controller = "Invoice", StyleButton = EnumButtonCss.Success, Text = "New Invoice" });
            ButtonModels.Add(new ButtonModel { Action = "Delete", Controller = "Invoice", StyleButton = EnumButtonCss.Danger, Text = "Delete Invoice" });
        }
    }
}
