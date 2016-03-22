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
		public  string CompanyId {
			set {
                var props = GetType().GetProperties(
					System.Reflection.BindingFlags.DeclaredOnly | 
					System.Reflection.BindingFlags.Instance | 
					System.Reflection.BindingFlags.Public);
				foreach (var prop in props) {
					if (prop.PropertyType.BaseType == typeof(BaseModelWithCompanyId)) {
                        ((BaseModelWithCompanyId)prop.GetValue(this, null)).CompanyId = value;
                    }
                }
                SetProperty (ref _companyId, value);
            }
			get { return _companyId; }
		}
	}
}
