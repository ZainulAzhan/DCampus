namespace dcampus.Application.Data;

public interface IApplicationDbContext
{
    DbSet<Programme> Programmes { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
