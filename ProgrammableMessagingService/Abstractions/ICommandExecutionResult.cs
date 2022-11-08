namespace ProgrammableMessagingService.Abstractions
{
    public interface ICommandExecutionResult<T, TResponse, TStatus>
    {
        T Source { get; }

        TResponse? Response { get; }

        TStatus Status { get; }
    }
}
