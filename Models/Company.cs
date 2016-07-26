using Newtonsoft.Json;
using SQLite.Net.Attributes;

namespace Amica.vNext.Models
{
	public class Company : BaseModel
	{
		private string _name, _password;

		/// <summary>
		/// Gets or sets the company name.
		/// </summary>
		/// <value>The company name.</value>
		[Indexed]
		public string Name {
			set { SetProperty (ref _name, value); }
			get { return _name; } 
		}

		public string Password {
			set { SetProperty (ref _password, value); }
			get { return _password; }
		}
	}
}
