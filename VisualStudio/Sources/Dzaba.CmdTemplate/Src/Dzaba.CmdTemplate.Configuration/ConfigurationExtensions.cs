using Dzaba.CmdTemplate.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dzaba.CmdTemplate.Configuration
{
    public static class ConfigurationExtensions
    {
        public static void RegisterSettings<T>(this IServiceCollection services, string sectionName)
            where T : class
        {
            Require.NotNull(services, nameof(services));
            Require.NotWhiteSpace(sectionName, nameof(sectionName));

            services.AddTransient<T>(p =>
            {
                var config = p.GetRequiredService<IConfiguration>();
                var section = config.GetSection(sectionName);
                return section.Get<T>();
            });
        }
    }
}
