using Hotelier.Core.Models.Abstracts;

namespace Hotelier.Core.Models;

public class EmailSubscribe : IEntity
{
    public int Id { get; set; }
    public string Email { get; set; }
}
