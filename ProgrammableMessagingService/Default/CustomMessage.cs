using ProgrammableMessagingService.Abstractions;

namespace ProgrammableMessagingService.Default
{
    public record struct CustomMessage : IMessage
    {
        public CustomMessage(string text, string from, string to, DateTime dateReceivedUTC)
        {
            Text = text;
            From = from;
            To = to;
            DateReceivedUTC = dateReceivedUTC;
        }
        public string Text { get; init; }

        public string From { get; init; }

        public string To { get; init; }

        public DateTime DateReceivedUTC { get; init; } = DateTime.Now;
    }
}
