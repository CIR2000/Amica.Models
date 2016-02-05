namespace Amica.vNext.Models
{
    public interface IContactMinimal : IUniqueId
    {
        string Name { get; set; }
        string Address { get; set; }
        string Vat { get; set; }
    }

    public interface IUniqueId
    {
        string UniqueId { get; set; }
    }
}
