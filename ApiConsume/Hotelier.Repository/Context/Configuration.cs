using Microsoft.Extensions.Configuration;

namespace Hotelier.Repository.Context;

static class Configuration
{
    public static string ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Hotelier.WebApi/"));
            configurationManager.AddJsonFile("appsettings.json");
            return configurationManager.GetConnectionString("SqlConnection");
        }
            
    }
}
