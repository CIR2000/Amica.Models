namespace Amica.vNext.Models
{
    public class CollectionItemOfInt : ObservableObject
    {
        private int _code;
        private string _description;

        public int Code
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
