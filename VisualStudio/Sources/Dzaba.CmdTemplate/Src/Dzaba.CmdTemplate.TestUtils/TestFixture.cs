using AutoFixture;
using AutoFixture.AutoMoq;

namespace Dzaba.CmdTemplate.TestUtils
{
    public static class TestFixture
    {
        public static IFixture Create()
        {
            return new Fixture()
                .Customize(new AutoMoqCustomization());
        }
    }
}
