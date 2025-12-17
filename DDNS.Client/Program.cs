using Kaven.Standard;

namespace DDNS.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.StartConsoleApplication<AppDynamicDomainNameClient>(new ConsoleApplicationStartOptions()
            {
                IoC = new IoC(),
            });
        }
    }
}
