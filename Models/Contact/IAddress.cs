namespace Amica.Models
{
    public interface IAddress
    {
		string Street { get; set; }
		string Town { get; set; }
		string PostalCode { get; set; }
		string StateOrProvince{ get; set; }
		string Country { get; set; }
        string Notes { get; set; }
    }
}
