using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using ServiceStack;

namespace vsCode
{
    public static class Program
    {
        private static IWebHost BuildWebHost(string[] args)
        {
            return WebHost
                .CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        }

        static void Main(string[] args = null)
        {
            BuildWebHost(args).Run();
        }
    }
}