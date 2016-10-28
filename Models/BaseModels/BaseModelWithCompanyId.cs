using Newtonsoft.Json;
using SQLite.Net.Attributes;
using System.Linq;
using System.Reflection;

namespace Amica.Models
{
	public abstract class BaseModelWithCompanyId : BaseModel
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
                var props = GetType().GetTypeInfo().DeclaredProperties;
				foreach (var prop in props) {

					if (prop.PropertyType.GetTypeInfo().BaseType == typeof(BaseModelWithCompanyId)) {

                        var obj = ((BaseModelWithCompanyId)prop.GetValue(this, null));
						if (obj != null)
							obj.CompanyId = value;
                    }
                }
                SetProperty (ref _companyId, value);
            }
			get { return _companyId; }
		}
	}
}
