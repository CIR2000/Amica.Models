namespace Amica.Models.Documents
{
    public class VariationCategory : ObservableObject
    {
        private DocumentVariation _category;
        private string _description;

        public DocumentVariation Category
        {
            set { SetProperty(ref _category, value); }
            get { return _category; }
        }

		public string Description {
			set { SetProperty (ref _description, value); }
			get { return _description; }
		}
    }
}
