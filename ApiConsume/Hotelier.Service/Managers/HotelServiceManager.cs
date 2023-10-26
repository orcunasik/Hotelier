using Hotelier.Core.Models;
using Hotelier.Core.Repositories.Abstracts.Base;
using Hotelier.Core.Services.Abstracts;
using Hotelier.Service.Managers.Base;

namespace Hotelier.Service.Managers;

public class HotelServiceManager : EntityService<HotelService>, IHotelServiceService
{
    public HotelServiceManager(IEntityRepository<HotelService> repository) : base(repository)
    {
    }
}
