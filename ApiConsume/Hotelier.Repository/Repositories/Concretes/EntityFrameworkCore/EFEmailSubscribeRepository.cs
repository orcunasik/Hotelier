using Hotelier.Core.Models;
using Hotelier.Core.Repositories.Abstracts;
using Hotelier.Repository.Context;
using Hotelier.Repository.Repositories.Concretes.EntityFrameworkCore.Base;

namespace Hotelier.Repository.Repositories.Concretes.EntityFrameworkCore;

public class EFEmailSubscribeRepository : EFEntityRepository<EmailSubscribe>, IEmailSubscribeRepository
{
    public EFEmailSubscribeRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
