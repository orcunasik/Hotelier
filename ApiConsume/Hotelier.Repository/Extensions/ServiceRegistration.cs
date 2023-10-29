using Hotelier.Core.Repositories.Abstracts;
using Hotelier.Repository.Context;
using Hotelier.Repository.Repositories.Concretes.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Hotelier.Repository.Extensions;

public static class ServiceRegistration
{
    public static void LoadMyRepositories(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));

        services.AddScoped<IStaffRepository, EFStaffRepository>();
        services.AddScoped<IRoomRepository, EFRoomRepository>();
        services.AddScoped<IEmailSubscribeRepository, EFEmailSubscribeRepository>();
        services.AddScoped<IHotelServiceRepository, EFHotelServiceRepository>();
        services.AddScoped<ITestimonialRepository, EFTestimonialRepository>();

    }
}
