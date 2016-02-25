using Newtonsoft.Json;

namespace Amica.vNext.Models
{
    public class AddressEx : Address, IAddressEx
    {
		public string Phone { get; set; }
		public string Mobile { get; set; }
		public string Fax { get; set; }
		public string Mail { get; set; }
		[JsonProperty("pec_mail")]
		public string PecMail { get; set; }
    }
}
