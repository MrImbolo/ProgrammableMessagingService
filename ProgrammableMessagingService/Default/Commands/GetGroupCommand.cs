using ProgrammableMessagingService.Abstractions;
using ProgrammableMessagingService.Misc;

namespace ProgrammableMessagingService.Default.Commands
{
    public class GetGroupCommand : CommandBase<IMessage, IMessage, EResponseStatus>
    {
        public GetGroupCommand(ICommandConstructorArgs<IMessage> args)
            : base(args)
        {
        }


        public override ICommandExecutionResult<IMessage, IMessage, EResponseStatus> Execute()
        {
            if (_args.Context.Something())
                return new MessageCommandExecutionResult(Source, EResponseStatus.SuccessMessage, new CustomMessage()
                {
                    DateReceivedUTC = DateTime.UtcNow,
                    From = Source.To,
                    To = Source.From,
                    Text = "Blah blah blak here is something useful"
                });

            return new MessageCommandExecutionResult(Source, EResponseStatus.ErrorMessage, new CustomMessage()
            {
                DateReceivedUTC = DateTime.UtcNow,
                From = Source.To,
                To = Source.From,
                Text = "Sorry, I cannot find anything useful for you."
            });
        }
    }
}
