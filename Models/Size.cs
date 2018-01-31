using System.Collections.Generic;
using Newtonsoft.Json;

namespace Amica.Models
{
    /// <summary>
    /// Size information.
    /// </summary>
    /// <seealso cref="Amica.Models.BaseModelWithCompanyId" />
    public class Size : BaseModelWithCompanyId
    {
        private string _name;
        private List<string> _numberCollection;

        /// <summary>
        /// Initializes a new instance of the <see cref="Size"/> class.
        /// </summary>
        public Size()
        {
            _numberCollection = new List<string>();
        }

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

        /// <summary>
        /// Gets or sets the numbers collection.
        /// </summary>
        /// <value>
        /// The numbers collection.
        /// </value>
        public List<string> NumberCollection
        {
            get { return _numberCollection; }
            set { SetProperty(ref _numberCollection, value); }
        }
    }
}
