using dcampus.Domain.Abstractions;

namespace dcampus.Domain.Models.Academics;

public class Programme : Entity<Guid>
{
    public string Code { get; private set; } = default!;
    public string Name { get; private set; } = default!;
    public string Description { get; private set; } = default!;

    public static Programme Create(Guid id, string code, string name, string description)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(code);
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentException.ThrowIfNullOrWhiteSpace(description);
        return new Programme
        {
            Id = id,
            Code = code,
            Name = name,
            Description = description
        };
    }
}
