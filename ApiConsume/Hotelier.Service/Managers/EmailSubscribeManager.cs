using Hotelier.Core.Models;
using Hotelier.Core.Repositories.Abstracts.Base;
using Hotelier.Core.Services.Abstracts;
using Hotelier.Service.Managers.Base;

namespace Hotelier.Service.Managers;

public class EmailSubscribeManager : EntityService<EmailSubscribe>, IEmailSubscribeService
{
    public EmailSubscribeManager(IEntityRepository<EmailSubscribe> repository) : base(repository)
    {
    }
}
