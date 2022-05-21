using Dzaba.CmdTemplate.Configuration.Json;
using Dzaba.CmdTemplate.Contracts;
using Dzaba.CmdTemplate.Engine;
using Dzaba.CmdTemplate.Utils;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.Threading.Tasks;

namespace Dzaba.CmdTemplate.Cmd
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                using (var container = BuildContiner())
                {
                    using (var app = container.GetRequiredService<IApp>())
                    {
                        await app.RunAsync()
                            .ConfigureAwait(false);
                    }
                }

                Environment.ExitCode = 0;
            }
            catch (ExitCodeException ex)
            {
                Console.WriteLine(ex.ToString());
                Environment.ExitCode = (int)ex.ExitCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Environment.ExitCode = 1;
            }
        }

        private static ServiceProvider BuildContiner()
        {
            var services = new ServiceCollection();

            RegisterLogging(services);
            services.RegisterServics();
            services.RegisterDzabaTestUtils();
            services.RegisterDzabaTestEngine();
            services.RegisterDzabaTestConfigurationJson();

            services.AddTransient<IApp, App>();

            return services.BuildServiceProvider();
        }

        private static void RegisterLogging(IServiceCollection services)
        {
            var loggerBuilder = new LoggerConfiguration();
            loggerBuilder.ConfigureLogging();
            var logger = loggerBuilder.CreateLogger();

            services.AddLogging(l => l.AddSerilog(logger, true));
        }
    }
}
