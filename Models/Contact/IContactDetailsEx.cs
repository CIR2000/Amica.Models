namespace Amica.vNext.Models
{
    public interface IContactDetailsEx : IContactDetails, IUniqueId
    {
		string Name { get; set; }
    }
}
