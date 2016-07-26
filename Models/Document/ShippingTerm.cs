namespace Amica.vNext.Models.Documents
{
    public class ShippingTerm : ObservableObject
    {
        private DocumentShippingTerm _code;
        private string _description;

        public DocumentShippingTerm Code
        {
            set { SetProperty(ref _code, value); }
            get { return _code; }
        }

        public string Description
        {
            set { SetProperty(ref _description, value); }
            get { return _description; }
        }
    }
}