using NUnit.Framework;

namespace Amica.vNext.Models.Tests
{
	[TestFixture]
	public class Document : BaseTestClass
	{
		[Test]
		public void WritablePropertyAssertions ()
		{
			WritablePropertyAssertions (typeof(Document));
		}
	}
}