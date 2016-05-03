using Newtonsoft.Json;
using SQLite.Net.Attributes;
using System.Linq;
#if NET45
using System.Reflection;
#endif

namespace Amica.vNext.Models
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
#if NET45
                var props = GetType().GetTypeInfo().DeclaredProperties;
#else
                var props = GetType().GetProperties(
					System.Reflection.BindingFlags.DeclaredOnly | 
					System.Reflection.BindingFlags.Instance | 
					System.Reflection.BindingFlags.Public);
#endif
				foreach (var prop in props) {
#if NET45

					if (prop.PropertyType.GetTypeInfo().BaseType == typeof(BaseModelWithCompanyId)) {
#else
					if (prop.PropertyType.BaseType == typeof(BaseModelWithCompanyId)) {
#endif

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
