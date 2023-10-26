using Hotelier.Core.Models.Abstracts;

namespace Hotelier.Core.Services.Abstracts.Base;

public interface IEntityService<T> where T : class, IEntity, new()
{
    List<T> GetAll();
    T GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);

}
