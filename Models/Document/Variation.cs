namespace Amica.Models.Documents
{
    public class Variation : ObservableObject
    {
        private string _description;
        private float _rate;
        private decimal _amount;
        private VariationCategory _category;

        public VariationCategory Category
        {
            set { SetProperty(ref _category, value); }
            get { return _category; }
        }
        public float Rate
        {
            set { SetProperty(ref _rate, value); }
            get { return _rate; }
        }

        public decimal Amount
        {
            set { SetProperty(ref _amount, value); }
            get { return _amount; }
        }
        public string Description
        {
            set { SetProperty(ref _description, value); }
            get { return _description; }
        }
    }
}
