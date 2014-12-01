using Newtonsoft.Json;

namespace Amica.vNext.Objects
{
    public class Company : BaseClass
    {
        private string _name, _password;

        /// <summary>
        /// Gets or sets the company name.
        /// </summary>
        /// <value>The company name.</value>
        [JsonProperty("n")]
        public string Name {
            set {SetProperty(ref _name, value); }
            get { return _name; } 
        }

        [JsonProperty("p")]
        public string Password
        {
            set { SetProperty(ref _password, value); }
            get { return _password; }
        }
    }
}
