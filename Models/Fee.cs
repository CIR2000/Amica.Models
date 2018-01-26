namespace Amica.Models
{
    /// <summary>
    /// Fee information.
    /// </summary>
    /// <seealso cref="Amica.Models.BaseModelWithCompanyId" />
    /// <seealso cref="Amica.Models.IUniqueId" />
    public class Fee : BaseModelWithCompanyId, IUniqueId
    {
        private string _name;
        private decimal _amount;
        private Vat _vat;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public decimal Amount
        {
            set { SetProperty(ref _amount, value); }
            get { return _amount; }
        }

        /// <summary>
        /// Gets or sets the VAT.
        /// </summary>
        /// <value>
        /// The VAT.
        /// </value>
        public Vat Vat
        {
            set { SetProperty(ref _vat, value); }
            get { return _vat; }
        }
    }
}
