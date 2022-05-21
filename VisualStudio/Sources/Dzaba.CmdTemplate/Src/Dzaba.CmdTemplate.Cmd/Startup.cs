using Dzaba.CmdTemplate.Utils;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;
using System;
using System.IO;

namespace Dzaba.CmdTemplate.Cmd
{
    internal static class Startup
    {
        public static void RegisterServics(this IServiceCollection services)
        {
            Require.NotNull(services, nameof(services));

            // Add additional cmd registrations here if needed
        }

        public static void ConfigureLogging(this LoggerConfiguration loggerConfiguration)
        {
            // Change it if needed

            var logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DzabaTest.log");

            loggerConfiguration
                .WriteTo.Console(LogEventLevel.Debug)
                .WriteTo.File(logPath, LogEventLevel.Debug,
                    fileSizeLimitBytes: 15 * 1024 * 1024,
                    rollingInterval: RollingInterval.Day,
                    rollOnFileSizeLimit: true,
                    retainedFileCountLimit: 15);
        }
    }
}
