using Hotelier.Core.Models.Abstracts;

namespace Hotelier.Core.Repositories.Abstracts.Base;

public interface IEntityRepository<T> where T : class, IEntity, new()
{
    List<T> GetList();
    T GetById(int id);
    void Insert(T entity);
    void Update(T entity);
    void Delete(T entity);
}
