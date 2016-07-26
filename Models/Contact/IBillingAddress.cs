namespace Amica.vNext.Models
{
    public interface IBillingAddress : IAddress, IUniqueId
    {
        string Name { get; set; }
        string VatIdentificationNumber { get; set; }
        string TaxIdentificationNumber { get; set; }
    }
}
