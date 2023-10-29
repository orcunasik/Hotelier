using Hotelier.Core.Models;
using Hotelier.Core.Repositories.Abstracts;
using Hotelier.Core.Services.Abstracts;

namespace Hotelier.Service.Managers;

public class RoomManager : IRoomService
{
    private readonly IRoomRepository _repository;
    public RoomManager(IRoomRepository roomRepository)
    {
        _repository = roomRepository;
    }

    public void Add(Room entity)
    {
        _repository.Insert(entity);
    }

    public void Delete(Room entity)
    {
        _repository.Delete(entity);
    }

    public List<Room> GetAll()
    {
        return _repository.GetList();
    }

    public Room GetById(int id)
    {
        return _repository.GetById(id);
    }

    public void Update(Room entity)
    {
        _repository.Update(entity);
    }
}
