using dcampus.Persistence.DatabaseContext;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace dcampus.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceServices
    (this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Database");
        services.AddDbContext<ApplicationDbContext>((sp, options) =>
        {
            options.UseSqlServer(connectionString);
        });
        services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
        return services;
    }
}
