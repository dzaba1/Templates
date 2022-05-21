using System;
using System.Threading.Tasks;

namespace Dzaba.CmdTemplate.Cmd
{
    public interface IApp : IDisposable
    {
        Task RunAsync();
    }

    internal sealed class App : IApp
    {
        public void Dispose()
        {
            // Implement it if needed
        }

        public async Task RunAsync()
        {
            // Implement it
        }
    }
}
