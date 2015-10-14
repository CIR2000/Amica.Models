using Newtonsoft.Json;

namespace Amica.vNext.Models
{
	public class BaseModelWithCompanyId : BaseModel
	{
		private string _companyId;

		/// <summary>
		/// Gets or sets the company Id.
		/// </summary>
		/// <value>The company identifier.</value>
		[JsonProperty ("c")]
        //[Remote (Meta.DocumentId)]
        //[PrimaryKey]
		public string CompanyId {
			set { SetProperty (ref _companyId, value); }
			get { return _companyId; }
		}
	}
}
