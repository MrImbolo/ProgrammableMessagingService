using ProgrammableMessagingService.Abstractions;
using ProgrammableMessagingService.Misc;

namespace ProgrammableMessagingService.Default
{
    public record MessageCommandExecutionResult : ICommandExecutionResult<IMessage, IMessage, EResponseStatus>
    {
        public MessageCommandExecutionResult(IMessage source, EResponseStatus status, IMessage? response = default)
        {
            Source = source;
            Status = status;
            Response = response;
        }
        public IMessage Source { get; }

        public IMessage? Response { get; }

        public EResponseStatus Status { get; }
    }
}
