using ProgrammableMessagingService.Abstractions;
using ProgrammableMessagingService.Misc;

namespace ProgrammableMessagingService.Default
{
    public class DefaultCommandConstructorArgs : ICommandConstructorArgs<IMessage>
    {
        public DefaultCommandConstructorArgs(Context context, IMessage source, INewService newService)
        {
            Context = context;
            Source = source;
            NewService = newService;
        }

        public Context Context { get; }

        public IMessage Source { get; }

        public INewService NewService { get; }
    }
}
