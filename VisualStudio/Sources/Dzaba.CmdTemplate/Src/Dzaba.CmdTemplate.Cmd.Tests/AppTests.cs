using AutoFixture;
using Dzaba.CmdTemplate.TestUtils;
using NUnit.Framework;

namespace Dzaba.CmdTemplate.Cmd.Tests
{
    [TestFixture]
    public class AppTests
    {
        private IFixture fixture;

        [SetUp]
        public void Setup()
        {
            fixture = TestFixture.Create();
        }

        private App CreateSut()
        {
            return fixture.Create<App>();
        }
    }
}
