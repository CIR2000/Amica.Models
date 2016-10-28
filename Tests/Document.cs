using NUnit.Framework;

namespace Amica.Models.Tests
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