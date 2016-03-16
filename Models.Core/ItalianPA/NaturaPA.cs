namespace Amica.vNext.Models.ItalianPA
{
    public class NaturaPA : ObservableObject
    {
        private string _code;
        private string _description;

        public string Name
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
