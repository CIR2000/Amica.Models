using Newtonsoft.Json;
using SQLite.Net.Attributes;

namespace Amica.vNext.Models
{
	public class BaseModelWithCompanyId : BaseModel
	{
		private string _companyId;

		/// <summary>
		/// Gets or sets the company Id.
		/// </summary>
		/// <value>The company identifier.</value>
		[JsonProperty ("company_id")]
		[Indexed][NotNull]
		public string CompanyId {
			set { SetProperty (ref _companyId, value); }
			get { return _companyId; }
		}
	}
}
