using Hotelier.Core.Models;
using Hotelier.Core.Repositories.Abstracts;
using Hotelier.Core.Services.Abstracts;

namespace Hotelier.Service.Managers;

public class EmailSubscribeManager : IEmailSubscribeService
{
    private readonly IEmailSubscribeRepository _repository;

    public EmailSubscribeManager(IEmailSubscribeRepository emailSubscribeRepository)
    {
        _repository = emailSubscribeRepository;
    }

    public void Add(EmailSubscribe entity)
    {
        _repository.Insert(entity);
    }

    public void Delete(EmailSubscribe entity)
    {
        _repository.Delete(entity);
    }

    public List<EmailSubscribe> GetAll()
    {
        return _repository.GetList();
    }

    public EmailSubscribe GetById(int id)
    {
        return _repository.GetById(id);
    }

    public void Update(EmailSubscribe entity)
    {
        _repository.Update(entity);
    }
}
