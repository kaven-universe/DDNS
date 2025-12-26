using Kaven.Standard;

namespace DDNS.Server
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            await Utility.StartConsoleApplication<AppDynamicDomainNameServer>(new ConsoleApplicationStartOptions()
            {
                IoC = new IoC(),
            });
        }
    }
}
