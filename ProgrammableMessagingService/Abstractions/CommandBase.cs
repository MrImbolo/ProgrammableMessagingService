using ProgrammableMessagingService.Abstractions;

namespace ProgrammableMessagingService
{
    public abstract class CommandBase<TSource, TResponse, TStatus> : ICommand<TSource, TResponse, TStatus>
    {
        protected readonly ICommandConstructorArgs<TSource> _args;

        public CommandBase(ICommandConstructorArgs<TSource> args)
        {
            _args = args;
        }

        public TSource Source => _args.Source;

        public abstract ICommandExecutionResult<TSource, TResponse, TStatus> Execute();

        public abstract ValueTask<ICommandExecutionResult<TSource, TResponse, TStatus>> ExecuteAsync(CancellationToken ct = default);
        
    }

    public interface ICommand<T, TResponse, TStatus>
    {
        T Source { get; }
        ICommandExecutionResult<T, TResponse, TStatus> Execute();
        ValueTask<ICommandExecutionResult<T, TResponse, TStatus>> ExecuteAsync(CancellationToken ct = default);
    }
}
