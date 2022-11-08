using ProgrammableMessagingService.Abstractions;
using ProgrammableMessagingService.Misc;

namespace ProgrammableMessagingService.Default.Commands
{
    public class StartCommand : CommandBase<IMessage, IMessage, EResponseStatus>
    {
        public StartCommand(ICommandConstructorArgs<IMessage> args)
            : base(args)
        {
        }


        public override ICommandExecutionResult<IMessage, IMessage, EResponseStatus> Execute()
        {
            if (_args.Context.Something())
            {
                return new MessageCommandExecutionResult(Source, EResponseStatus.ProceedMessage, new CustomMessage
                {
                    DateReceivedUTC = DateTime.UtcNow,
                    From = Source.To,
                    To = Source.From,
                    Text = "Your group was found and you've been added to the list of group's schedule receivers"
                });
            }

            return new MessageCommandExecutionResult(Source, EResponseStatus.ErrorMessage, new CustomMessage
            {
                DateReceivedUTC = DateTime.UtcNow,
                From = Source.To,
                To = Source.From,
                Text = "Sorry, the group you're looking for does not exist."
            });
        }
    }
}
