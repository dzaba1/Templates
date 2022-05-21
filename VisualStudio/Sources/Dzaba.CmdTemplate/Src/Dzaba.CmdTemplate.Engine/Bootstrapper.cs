using Dzaba.CmdTemplate.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace Dzaba.CmdTemplate.Engine
{
    public static class Bootstrapper
    {
        public static void RegisterDzabaTestEngine(this IServiceCollection services)
        {
            Require.NotNull(services, nameof(services));

            // Add registrations here
        }
    }
}
