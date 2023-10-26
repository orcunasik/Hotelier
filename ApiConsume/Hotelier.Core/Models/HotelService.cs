using Hotelier.Core.Models.Abstracts;

namespace Hotelier.Core.Models;

public class HotelService : BaseEntity, IEntity
{
    public string Icon { get; set; }
    public string Description { get; set; }
}
