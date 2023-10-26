using Hotelier.Core.Models;
using Hotelier.Core.Repositories.Abstracts;
using Hotelier.Repository.Context;
using Hotelier.Repository.Repositories.Concretes.EntityFrameworkCore.Base;

namespace Hotelier.Repository.Repositories.Concretes.EntityFrameworkCore;

public class EFStaffRepository : EFEntityRepository<Staff>, IStaffRepository
{
    public EFStaffRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
