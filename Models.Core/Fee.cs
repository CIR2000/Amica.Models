namespace Amica.vNext.Models
{
    public class Fee : BaseModelWithCompanyId
    {
        private string _name;
        private decimal _amount;
        private Vat _vat = new Vat();

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets wether this is a RiBa method.
        /// </summary>
        /// <value>The wether this is a RiBa method.</value>
        public decimal Amount
        {
            set { SetProperty(ref _amount, value); }
            get { return _amount; }
        }

        public Vat Vat
        {
            set { SetProperty(ref _vat, value); }
            get { return _vat; }
        }
    }
}
