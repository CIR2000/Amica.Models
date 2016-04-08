namespace Amica.vNext.Models
{
    public interface IContactMinimal : IAddress, IUniqueId
    {
        string Name { get; set; }
        string VatIdentificationNumber { get; set; }
        string TaxIdentificationNumber { get; set; }
    }
}
