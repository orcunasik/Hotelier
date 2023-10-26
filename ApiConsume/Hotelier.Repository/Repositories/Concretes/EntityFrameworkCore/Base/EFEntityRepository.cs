using Hotelier.Core.Models.Abstracts;
using Hotelier.Core.Repositories.Abstracts.Base;
using Hotelier.Repository.Context;

namespace Hotelier.Repository.Repositories.Concretes.EntityFrameworkCore.Base;

public class EFEntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
{
    private readonly AppDbContext _context;

    public EFEntityRepository(AppDbContext appDbContext)
    {
        _context = appDbContext;
    }

    public void Delete(TEntity entity)
    {
        _context.Remove(entity);
        _context.SaveChanges();
    }

    public TEntity GetById(int id)
    {
        return _context.Set<TEntity>().Find(id);
    }

    public List<TEntity> GetList()
    {
        return _context.Set<TEntity>().ToList();
    }

    public void Insert(TEntity entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        _context.Update(entity);
        _context.SaveChanges();
    }
}
