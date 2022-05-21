using Microsoft.Extensions.DependencyInjection;

namespace Dzaba.CmdTemplate.Utils
{
    public static class Bootstrapper
    {
        public static void RegisterDzabaTestUtils(this IServiceCollection services)
        {
            Require.NotNull(services, nameof(services));

            // Add utils registrations here
        }
    }
}
