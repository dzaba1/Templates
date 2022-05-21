using Dzaba.CmdTemplate.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace Dzaba.CmdTemplate.Configuration.Json
{
    public static class Bootstrapper
    {
        public static void RegisterDzabaTestConfigurationJson(this IServiceCollection services)
        {
            Require.NotNull(services, nameof(services));

            services.AddTransient<IConfiguration>(p =>
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
                return new ConfigurationBuilder()
                    .AddJsonFile(path)
                    .Build();
            });
        }
    }
}
