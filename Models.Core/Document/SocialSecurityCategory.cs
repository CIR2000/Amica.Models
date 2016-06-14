namespace Amica.vNext.Models.Documents
{
    public class SocialSecurityCategory : ObservableObject
    {
        private SocialSecurityCategoryType _category;
        private string _description;

        public SocialSecurityCategoryType Category
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
