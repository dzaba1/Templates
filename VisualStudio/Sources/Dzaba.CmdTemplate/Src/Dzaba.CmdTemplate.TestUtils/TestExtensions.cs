using AutoFixture;
using Dzaba.CmdTemplate.Utils;
using Moq;

namespace Dzaba.CmdTemplate.TestUtils
{
    public static class TestExtensions
    {
        public static Mock<T> FreezeMock<T>(this IFixture fixture)
            where T : class
        {
            Require.NotNull(fixture, nameof(fixture));

            return fixture.Freeze<Mock<T>>();
        }
    }
}
