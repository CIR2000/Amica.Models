namespace Amica.vNext.Models.Documents
{
    public class Status : ObservableObject
    {
        private DocumentStatus _code;
        private string _description;

        public DocumentStatus Code
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