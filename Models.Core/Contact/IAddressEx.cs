namespace Amica.vNext.Models
{
    public interface IAddressEx : IAddress
    {
		string Phone { get; set; }
		string Mobile { get; set; }
		string Fax { get; set; }
		string Mail { get; set; }
		string PecMail { get; set; }
		string WebSite { get; set; }
    }
}
