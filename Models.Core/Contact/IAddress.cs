namespace Amica.vNext.Models
{
    public interface IAddress
    {
		string Street { get; set; }
		string Town { get; set; }
		string PostalCode { get; set; }
		string Province{ get; set; }
		string State { get; set; }
    }
}
