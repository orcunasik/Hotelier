using Hotelier.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Hotelier.Repository.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Room> Rooms { get; set; }
    public DbSet<HotelService> HotelServices { get; set; }
    public DbSet<Staff> Staffs { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<EmailSubscribe> EmailSubscribes { get; set; }

}
