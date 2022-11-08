using ProgrammableMessagingService.Abstractions;
using ProgrammableMessagingService.Misc;
using System.Net.Sockets;
using Telegram.Bot.Types;

namespace ProgrammableMessagingService.Telegram.Commands
{
    public class TgErrorCommand : CommandBase<Update, Message, EResponseStatus>
    {
        public TgErrorCommand(ICommandConstructorArgs<Update> args)
            : base(args)
        {
        }


        public override ICommandExecutionResult<Update, Message, EResponseStatus> Execute()
        {
            return new TgCommandExecutionResult(Source, EResponseStatus.ErrorMessage, new Message()
            {
                Text = "Sorry, I can't understard the bullshit you've typed."
            });
        }
    }
}
