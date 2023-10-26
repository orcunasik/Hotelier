using Hotelier.Core.Models.Abstracts;

namespace Hotelier.Core.Models;

public class Testimonial : BaseEntity, IEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Image { get; set; }
    public string Comment { get; set; }
}
