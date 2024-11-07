using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using petfriend_api.Database.MongoDatabaseCollection;

public class Startup
{
    public Startup()
    {
        Configuration = SetupConfiguration();
    }

    public IConfiguration Configuration { get; }

    private static IConfiguration SetupConfiguration()
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false, true)
            .AddEnvironmentVariables();
        return configuration.Build();
    }
}
