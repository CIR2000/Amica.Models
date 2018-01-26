namespace Amica.Models
{
    /// <summary>
    /// Payment option.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class FirstPaymentOption : ObservableObject
    {
        private PaymentOption _code;
        private string _description;

        /// <summary>
        /// Gets or sets the payment option.
        /// </summary>
        /// <value>
        /// The payment option.
        /// </value>
        public PaymentOption Option
        {
            set { SetProperty(ref _code, value); }
            get { return _code; }
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description
        {
            set { SetProperty(ref _description, value); }
            get { return _description; }
        }
    }
}