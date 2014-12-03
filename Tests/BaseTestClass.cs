using System;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Idioms;

namespace Amica.vNext.Models.Tests
{
	public class BaseTestClass
	{
		/// <summary>
		/// Test that all writable properties of a given type instance are behaving properly.
		/// </summary>
		/// <param name="t"></param>
		public void WritablePropertyAssertions (Type t)
		{
			var fixture = new Fixture ();
			var assertion = new WritablePropertyAssertion (fixture);

			assertion.Verify (t.GetProperties ());
		}
	}
}
