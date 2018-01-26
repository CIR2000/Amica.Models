namespace Amica.Models
{
    /// <summary>
    /// Currency informations.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class Currency : ObservableObject
    {
        private string _name;
        private string _code;
        private string _symbol;

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
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Code
        {
            set { SetProperty(ref _code, value); }
            get { return _code; }
        }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol
        {
            set { SetProperty(ref _symbol, value); }
            get { return _symbol; }
        }
    }
}
