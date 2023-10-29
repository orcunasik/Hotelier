using Hotelier.Core.Models;
using Hotelier.Core.Repositories.Abstracts;
using Hotelier.Core.Services.Abstracts;

namespace Hotelier.Service.Managers;

public class HotelServiceManager : IHotelServiceService
{
    private readonly IHotelServiceRepository _repository;

    public HotelServiceManager(IHotelServiceRepository hotelServiceRepository)
    {
        _repository = hotelServiceRepository;
    }

    public void Add(HotelService entity)
    {
        _repository.Insert(entity);
    }

    public void Delete(HotelService entity)
    {
        _repository.Delete(entity);
    }

    public List<HotelService> GetAll()
    {
        return _repository.GetList();
    }

    public HotelService GetById(int id)
    {
        return _repository.GetById(id);
    }

    public void Update(HotelService entity)
    {
        _repository.Update(entity);
    }
}
