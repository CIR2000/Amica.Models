namespace Amica.vNext.Models
{
    public interface IContactMinimal : IAddress, IUniqueId
    {
        string Name { get; set; }
        string VatIdentificationNumber { get; set; }
    }

    public interface IUniqueId
    {
        string UniqueId { get; set; }
    }
}
