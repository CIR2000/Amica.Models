using Amica.Models.Resources;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Amica.Models.PropertyModels
{
    /// <summary>
    /// VAT details. To be used as a property.
    /// </summary>
    public class Vat : Models.Vat
    {
        /// <summary>
        /// Gets or sets the VAT name.
        /// </summary>
        /// <value>The VAT name.</value>
        [JsonProperty("_id")]
        [Display(Name = nameof(Properties.UniqueId), ResourceType = typeof(Properties))]
        public new string UniqueId
        {
            set { SetProperty(ref _uniqueId, value); }
            get { return _uniqueId; }
        }
    }
}
