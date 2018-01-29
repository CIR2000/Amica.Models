namespace Amica.Models
{
    /// <summary>
    /// Firat payment information.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class FirstPaymentDate : ObservableObject
    {
        private PaymentDate _code;
        private string _description;

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public PaymentDate Option
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
