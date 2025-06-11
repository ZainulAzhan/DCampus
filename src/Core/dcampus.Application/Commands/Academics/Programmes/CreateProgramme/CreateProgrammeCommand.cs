namespace dcampus.Application.Commands.Academics.Programmes.CreateProgramme;

public record CreateProgrammeCommand(ProgrammeDto Programme) : ICommand<CreateProgrammeResult>;

public record CreateProgrammeResult(Guid Id);