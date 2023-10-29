using Hotelier.Core.Services.Abstracts;
using Hotelier.Service.Managers;
using Microsoft.Extensions.DependencyInjection;

namespace Hotelier.Service.Extensions;

public static class ServiceRegistration
{
    public static void LoadMyServices(this IServiceCollection services)
    {
        services.AddScoped<IStaffService, StaffManager>();
        services.AddScoped<IRoomService, RoomManager>();
        services.AddScoped<IEmailSubscribeService, EmailSubscribeManager>();
        services.AddScoped<IHotelServiceService, HotelServiceManager>();
        services.AddScoped<ITestimonialService, TestimonialManager>();
    }
}
