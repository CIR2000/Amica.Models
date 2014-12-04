using Newtonsoft.Json;

namespace Amica.vNext.Models
{
	public class Country : BaseModel
	{
		private string _name;

		/// <summary>
		/// Gets or sets the country name.
		/// </summary>
		/// <value>The country name.</value>
		[JsonProperty ("n")]
		public string Name {
			set { SetProperty (ref _name, value); }
			get { return _name; }
		}
	}
}
