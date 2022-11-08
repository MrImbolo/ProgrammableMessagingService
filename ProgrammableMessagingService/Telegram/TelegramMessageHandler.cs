using ProgrammableMessagingService.Abstractions;
using ProgrammableMessagingService.Misc;
using ProgrammableMessagingService.Telegram.Commands;
using Telegram.Bot.Types;

namespace ProgrammableMessagingService.Telegram
{
    public class TelegramMessageHandler : ICommandHandler<Update, Message, EResponseStatus>
    {
        private readonly Context _context;
        private readonly Func<Update, string> _cmdSelector;

        public TelegramMessageHandler(Context context, Func<Update, string> cmdSelector)
        {
            _context = context;
            _cmdSelector = cmdSelector;
        }

        public Dictionary<string, Func<ICommandConstructorArgs<Update>, ICommand<Update, Message, EResponseStatus>>> _factories = new()
        {
            { "/start", static (args) => new TgStartCommand(args)},
            { "/get", static (args) => new TgGetCommand(args)},
        };

        public ICommandExecutionResult<Update, Message, EResponseStatus> Handle(Update message)
        {
            var cmdText = _cmdSelector(message);

            if (_factories.TryGetValue(cmdText, out var factory))
            {
                var cmd = factory(new TgCommandConstructorArgs(_context, message, null!));
                var result = cmd.Execute();

                return result;
            }

            return new TgErrorCommand(new TgCommandConstructorArgs(_context, message, null!)).Execute();
        }
    }
}
