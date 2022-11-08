using ProgrammableMessagingService.Abstractions;
using ProgrammableMessagingService.Misc;

namespace ProgrammableMessagingService.Default.Commands
{
    public class ErrorCommand : CommandBase<IMessage, IMessage, EResponseStatus>
    {

        public ErrorCommand(ICommandConstructorArgs<IMessage> args)
            : base(args)
        {
        }


        public override ICommandExecutionResult<IMessage, IMessage, EResponseStatus> Execute()
        {
            return new MessageCommandExecutionResult(Source, EResponseStatus.ErrorMessage, new CustomMessage()
            {
                DateReceivedUTC = DateTime.UtcNow,
                From = Source.To,
                To = Source.From,
                Text = "Sorry, I can't understard the bullshit you've typed."
            });
        }
    }
}
