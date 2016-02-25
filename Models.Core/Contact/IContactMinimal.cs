namespace Amica.vNext.Models
{
    public interface IContactMinimal : IAddress, IUniqueId
    {
        string Name { get; set; }
        string Vat { get; set; }
    }

    public interface IUniqueId
    {
        string UniqueId { get; set; }
    }
}
