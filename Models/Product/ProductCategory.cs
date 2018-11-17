using System.Collections.Generic;
using Newtonsoft.Json;

namespace Amica.Models
{
    /// <summary>
    /// Product category.
    /// </summary>
    /// <seealso cref="Amica.Models.BaseModelWithCompanyId" />
    public class ProductCategory : BaseModelWithCompanyId
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
