namespace Amica.Models
{
    public interface IContactDetailsEx : IContactDetails, IUniqueId
    {
		string Name { get; set; }
    }
}
