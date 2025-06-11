using MediatR;

namespace dcampus.Infrastructure.CQRS;

public interface ICommand : ICommand<Unit>
{
}
public interface ICommand<out TResponse> : IRequest<TResponse>
{
}
