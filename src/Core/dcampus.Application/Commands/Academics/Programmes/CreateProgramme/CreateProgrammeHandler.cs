using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace dcampus.Application.Commands.Academics.Programmes.CreateProgramme;

public class CreateProgrammeHandler(IApplicationDbContext dbContext) : ICommandHandler<CreateProgrammeCommand, CreateProgrammeResult>
{
    public async Task<CreateProgrammeResult> Handle(CreateProgrammeCommand command, CancellationToken cancellationToken)
    {
        var programme = CreateNewOrder(command.Programme);
        dbContext.Programmes.Add(programme);
        await dbContext.SaveChangesAsync(cancellationToken);
        return new CreateProgrammeResult(programme.Id);
    }

    private Programme CreateNewOrder(ProgrammeDto programmeDto)
    {
        var newProgramme = Programme.Create(
            Guid.NewGuid(),
            programmeDto.Code,
            programmeDto.Name,
            programmeDto.Description
        );
        return newProgramme;
    }
}
