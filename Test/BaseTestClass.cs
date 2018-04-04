using System;
using AutoFixture;
using AutoFixture.Idioms;

namespace Amica.Models.Tests
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
