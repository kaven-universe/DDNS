using Kaven.Standard;

namespace DDNS.Client
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            await Utility.StartConsoleApplication<AppDynamicDomainNameClient>(new ConsoleApplicationStartOptions()
            {
                IoC = new IoC(),
            });
        }
    }
}
