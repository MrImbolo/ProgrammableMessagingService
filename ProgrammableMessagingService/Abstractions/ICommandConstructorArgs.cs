using ProgrammableMessagingService.Misc;

namespace ProgrammableMessagingService.Abstractions
{
    public interface ICommandConstructorArgs<T>
    {
        Context Context { get; }
        T Source { get; }
        INewService NewService { get; }
    }
}
