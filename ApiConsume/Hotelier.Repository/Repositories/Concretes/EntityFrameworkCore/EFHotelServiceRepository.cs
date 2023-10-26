using Hotelier.Core.Models;
using Hotelier.Core.Repositories.Abstracts;
using Hotelier.Repository.Context;
using Hotelier.Repository.Repositories.Concretes.EntityFrameworkCore.Base;

namespace Hotelier.Repository.Repositories.Concretes.EntityFrameworkCore;

public class EFHotelServiceRepository : EFEntityRepository<HotelService>, IHotelServiceRepository
{
    public EFHotelServiceRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
