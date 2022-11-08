using ProgrammableMessagingService.Abstractions;

namespace ProgrammableMessagingService
{
    public interface ICommandHandler<T, TResponse, TStatus>
    {
        ICommandExecutionResult<T, TResponse, TStatus> Handle(T message);
        ValueTask<ICommandExecutionResult<T, TResponse, TStatus>> HandleAsync(T message);
    }
}
