using System;
using System.Collections.Generic;
using System.Text;
using Amica.vNext.Models.Documents;

namespace Amica.vNext.Models
{
	public class DefaultFactories
    {
        private static bool _bootstrapped = false;

		public static void Bootstrap()
        {
            if (_bootstrapped) return;

            Factory<Document>.Register(typeof(Invoice), () => new Invoice());
            Factory<Vat>.Register(typeof(Vat), () => new Vat());

            _bootstrapped = true;
        }
        public static bool Bootstrapped => _bootstrapped;
    }
}
