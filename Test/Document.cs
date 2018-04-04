using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amica.Models.Tests
{
	[TestClass]
	public class Document : BaseTestClass
	{
		[TestMethod]
		public void WritablePropertyAssertions ()
		{
			WritablePropertyAssertions (typeof(Document));
		}
	}
}