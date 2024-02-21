using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
    WebHost.CreateDefaultBuilder(args)
    .ConfigureLogging(logBuilder =>
    {
        logBuilder.ClearProviders(); // removes all providers from LoggerFactory
        logBuilder.AddConsole();
        logBuilder.AddTraceSource("Information, ActivityTracing"); // Add Trace listener provider
    })
    .UseStartup<Startup>();
    }
}
