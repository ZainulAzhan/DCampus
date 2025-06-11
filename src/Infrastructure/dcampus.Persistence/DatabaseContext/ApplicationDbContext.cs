using System.Reflection;

namespace dcampus.Persistence.DatabaseContext;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<Programme> Programmes => Set<Programme>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}
