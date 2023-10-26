using Hotelier.Core.Models;
using Hotelier.Core.Repositories.Abstracts.Base;
using Hotelier.Core.Services.Abstracts;
using Hotelier.Service.Managers.Base;

namespace Hotelier.Service.Managers;

public class StaffManager : EntityService<Staff>, IStaffService
{
    public StaffManager(IEntityRepository<Staff> repository) : base(repository)
    {
    }
}
