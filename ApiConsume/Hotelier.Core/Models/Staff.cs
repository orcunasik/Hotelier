using Hotelier.Core.Models.Abstracts;

namespace Hotelier.Core.Models;

public class Staff : BaseEntity, IEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SocialMedia1 { get; set; }
    public string SocialMedia2 { get; set; }
    public string SocialMedia3 { get; set; }

}
