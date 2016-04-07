namespace Amica.vNext.Models.Documents
{
    public class Category : ObservableObject
    {
        private DocumentCategory _code;
        private string _description;

        public DocumentCategory Code
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