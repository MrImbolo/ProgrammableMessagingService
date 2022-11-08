using ProgrammableMessagingService.Abstractions;
using ProgrammableMessagingService.Misc;
using Telegram.Bot.Types;

namespace ProgrammableMessagingService.Telegram
{
    public record TgCommandExecutionResult : ICommandExecutionResult<Update, Message, EResponseStatus>
    {
        public TgCommandExecutionResult(Update source, EResponseStatus status, Message? response = default)
        {
            Source = source;
            Status = status;
            Response = response;
        }
        public Update Source { get; }

        public Message? Response { get; }

        public EResponseStatus Status { get; }
    }
}
