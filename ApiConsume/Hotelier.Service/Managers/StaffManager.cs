using Hotelier.Core.Models;
using Hotelier.Core.Repositories.Abstracts;
using Hotelier.Core.Services.Abstracts;

namespace Hotelier.Service.Managers;

public class StaffManager : IStaffService
{
    private readonly IStaffRepository _repository;

    public StaffManager(IStaffRepository staffRepository)
    {
        _repository = staffRepository;
    }

    public void Add(Staff entity)
    {
        _repository.Insert(entity);
    }

    public void Delete(Staff entity)
    {
        _repository.Delete(entity);
    }

    public List<Staff> GetAll()
    {
        return _repository.GetList();
    }

    public Staff GetById(int id)
    {
        return _repository.GetById(id);
    }

    public void Update(Staff entity)
    {
        _repository.Update(entity);
    }
}
