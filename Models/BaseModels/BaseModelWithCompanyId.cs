using Newtonsoft.Json;
using System.Reflection;

namespace Amica.Models
{
    /// <summary>
    /// Base class for concrete data models with a company identifier.
    /// </summary>
    /// <seealso cref="Amica.Models.BaseModel" />
    public abstract class BaseModelWithCompanyId : BaseModel
	{
		private string _companyId;

		/// <summary>
		/// Gets or sets the company identifier.
		/// </summary>
		/// <value>The company identifier.</value>
		[JsonProperty ("company_id")]
		public  string CompanyId {
			set {
                //var props = GetType().GetTypeInfo().DeclaredProperties;
				//foreach (var prop in props) {

					//if (prop.PropertyType.GetTypeInfo().BaseType == typeof(BaseModelWithCompanyId)) {

                        //var obj = ((BaseModelWithCompanyId)prop.GetValue(this, null));
						//if (obj != null)
							//obj.CompanyId = value;
                    //}
                //}
                SetProperty (ref _companyId, value);
            }
			get { return _companyId; }
		}
	}
}
