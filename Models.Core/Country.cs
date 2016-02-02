using Newtonsoft.Json;

namespace Amica.vNext.Models
{
	public class Country : BaseModelWithCompanyId
	{
		private string _name;

		/// <summary>
		/// Gets or sets the country name.
		/// </summary>
		/// <value>The country name.</value>
		public string Name {
			set { SetProperty (ref _name, value); }
			get { return _name; }
		}
	}
}
