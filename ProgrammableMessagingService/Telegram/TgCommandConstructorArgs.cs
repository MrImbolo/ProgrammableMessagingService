using ProgrammableMessagingService.Abstractions;
using ProgrammableMessagingService.Misc;
using Telegram.Bot.Types;

namespace ProgrammableMessagingService.Telegram
{
    internal class TgCommandConstructorArgs : ICommandConstructorArgs<Update>
    {
        public TgCommandConstructorArgs(Context context, Update source, INewService newService)
        {
            Context = context;
            Source = source;
            NewService = newService;
        }
        public Context Context { get; }

        public Update Source { get; }

        public INewService NewService { get; }
    }
}