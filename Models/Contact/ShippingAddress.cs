namespace Amica.Models
{
    /// <summary>
    /// Shipping address information.
    /// </summary>
    /// <seealso cref="Amica.Models.AddressEx" />
    public class ShippingAddress : AddressEx
    {
        private string _name;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
    }
}
