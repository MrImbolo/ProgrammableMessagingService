using ProgrammableMessagingService.Abstractions;
using ProgrammableMessagingService.Misc;
using Telegram.Bot.Types;

namespace ProgrammableMessagingService.Telegram.Commands
{
    public class TgStartCommand : CommandBase<Update, Message, EResponseStatus>
    {
        public TgStartCommand(ICommandConstructorArgs<Update> args)
            : base(args)
        {
        }

        public override ICommandExecutionResult<Update, Message, EResponseStatus> Execute()
        {
            return new TgCommandExecutionResult(Source, EResponseStatus.ProceedMessage, new Message
            {
                Text = "Bot started. VOILA BITCHES!"
            });
        }
    }
}
