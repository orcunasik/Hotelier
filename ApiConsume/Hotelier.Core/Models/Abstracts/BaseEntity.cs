namespace Hotelier.Core.Models.Abstracts;

public abstract class BaseEntity
{
    public virtual int Id { get; set; }
    public virtual string Title { get; set; }
}
