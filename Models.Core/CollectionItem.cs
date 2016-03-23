namespace Amica.vNext.Models
{
    public class CollectionItem : ObservableObject
    {
        private string _code;
        private string _description;

        public string Code
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
