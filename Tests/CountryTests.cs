using NUnit.Framework;

namespace Amica.vNext.Objects.Tests
{
    [TestFixture]
    public class CountryTests : BaseTestClass
    {
        [Test]
        public void WritablePropertyAssertions() {
            WritablePropertyAssertions(typeof(Country));
        } 
    }
}