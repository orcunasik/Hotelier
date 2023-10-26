using Hotelier.Core.Models;
using Hotelier.Core.Repositories.Abstracts;
using Hotelier.Repository.Context;
using Hotelier.Repository.Repositories.Concretes.EntityFrameworkCore.Base;

namespace Hotelier.Repository.Repositories.Concretes.EntityFrameworkCore;

public class EFRoomRepository : EFEntityRepository<Room>, IRoomRepository
{
    public EFRoomRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
