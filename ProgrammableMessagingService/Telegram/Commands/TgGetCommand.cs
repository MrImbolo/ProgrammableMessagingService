using ProgrammableMessagingService.Abstractions;
using ProgrammableMessagingService.Misc;
using Telegram.Bot.Types;

namespace ProgrammableMessagingService.Telegram.Commands
{
    public class TgGetCommand : CommandBase<Update, Message, EResponseStatus>
    {

        public TgGetCommand(ICommandConstructorArgs<Update> args)
            : base(args)
        {
        }


        public override ICommandExecutionResult<Update, Message, EResponseStatus> Execute()
        {
            if (_args.Context.Something())
                return new TgCommandExecutionResult(Source, EResponseStatus.SuccessMessage, new Message()
                {
                    Text = "Blah blah blak here is something useful"
                });

            return new TgCommandExecutionResult(Source, EResponseStatus.ErrorMessage, new Message()
            {
                Text = "Sorry, I cannot find anything useful for you."
            });
        }
    }
}
