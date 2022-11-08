using ProgrammableMessagingService.Abstractions;
using ProgrammableMessagingService.Default.Commands;
using ProgrammableMessagingService.Misc;

namespace ProgrammableMessagingService.Default
{

    public class MessageCommandHandler : ICommandHandler<IMessage, IMessage, EResponseStatus>
    {
        private readonly Context _context;
        private readonly Func<IMessage, string> _commandSeparatorPredecate;

        public MessageCommandHandler(Context context, Func<IMessage, string> commandSeparatorPredecate)
        {
            _context = context;
            _commandSeparatorPredecate = commandSeparatorPredecate;
        }

        public Dictionary<string, Func<ICommandConstructorArgs<IMessage>, ICommand<IMessage, IMessage, EResponseStatus>>> _factories = new()
        {
            { "/start", static (args) => new StartCommand(args)},
            { "/get", static (args) => new GetGroupCommand(args)},
        };

        public ICommandExecutionResult<IMessage, IMessage, EResponseStatus> Handle(IMessage message)
        {
            var cmdText = _commandSeparatorPredecate(message);
            if (_factories.TryGetValue(cmdText, out var factory))
            {
                var cmd = factory(new DefaultCommandConstructorArgs(_context, message, null!));
                var result = cmd.Execute();

                return result;
            }

            return new ErrorCommand(new DefaultCommandConstructorArgs(_context, message, null!)).Execute();
        }

        public ValueTask<ICommandExecutionResult<IMessage, IMessage, EResponseStatus>> HandleAsync(IMessage message)
        {
            return ValueTask.FromResult(Handle(message));
        }
    }
}
