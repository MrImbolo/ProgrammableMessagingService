using ProgrammableMessagingService.Abstractions;

namespace ProgrammableMessagingService
{
    public abstract class CommandBase<T, TResponse, TStatus> : ICommand<T, TResponse, TStatus>
    {
        protected readonly ICommandConstructorArgs<T> _args;

        public CommandBase(ICommandConstructorArgs<T> args)
        {
            _args = args;
        }

        public T Source => _args.Source;

        public abstract ICommandExecutionResult<T, TResponse, TStatus> Execute();
    }

    public interface ICommand<T, TResponse, TStatus>
    {
        T Source { get; }
        ICommandExecutionResult<T, TResponse, TStatus> Execute();
    }
}
