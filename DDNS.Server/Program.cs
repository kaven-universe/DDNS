using Kaven.Standard;

namespace DDNS.Server
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Utility.StartConsoleApplication<AppDynamicDomainNameServer>(new ConsoleApplicationStartOptions()
            {
                IoC = new IoC(),
            });
        }
    }
}
