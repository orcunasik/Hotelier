using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Hotelier.Repository.Context;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder optionsBuilder = new();
        optionsBuilder.UseSqlServer(Configuration.ConnectionString);
        return new(optionsBuilder.Options);
    }
}
