namespace ProgrammableMessagingService.Misc
{
    public class Context
    {
        public bool Something() => Convert.ToBoolean(Random.Shared.Next(0, 2));
    }
}
