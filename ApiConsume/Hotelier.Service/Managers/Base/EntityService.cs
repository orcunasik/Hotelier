using Hotelier.Core.Models.Abstracts;
using Hotelier.Core.Repositories.Abstracts.Base;
using Hotelier.Core.Services.Abstracts.Base;

namespace Hotelier.Service.Managers.Base;

public class EntityService<TEntity> : IEntityService<TEntity> where TEntity : class, IEntity, new()
{
    private readonly IEntityRepository<TEntity> _repository;

    public EntityService(IEntityRepository<TEntity> repository)
    {
        _repository = repository;
    }

    public void Add(TEntity entity)
    {
        _repository.Insert(entity);
    }

    public void Delete(TEntity entity)
    {
        _repository.Delete(entity);
    }

    public List<TEntity> GetAll()
    {
        return _repository.GetList();
    }

    public TEntity GetById(int id)
    {
        return _repository.GetById(id);
    }

    public void Update(TEntity entity)
    {
        _repository.Update(entity);
    }
}
