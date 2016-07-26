namespace Amica.vNext.Models.Documents
{
    public class TransportMode : ObservableObject
    {
        private DocumentTransportMode _code;
        private string _description;

        public DocumentTransportMode Code
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