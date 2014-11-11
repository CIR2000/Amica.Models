using Newtonsoft.Json;

namespace Amica.vNext.Objects
{
    public class Country : BaseClass
    {
        /// <summary>
        /// Gets or sets the country name.
        /// </summary>
        /// <value>The country name.</value>
        [JsonProperty("n")]
        public string Name { get; set; }
    }
}
