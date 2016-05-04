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

            Factory<Vat>.Register(() => new Vat());
            Factory<Company>.Register(() => new Company());
            Factory<Contact>.Register(() => new Contact());
            Factory<Fee>.Register(() => new Fee());
            Factory<Payment>.Register(() => new Payment());
            Factory<PaymentMethod>.Register(() => new PaymentMethod());
            Factory<Document>.Register(typeof(Invoice), () => new Invoice());

            _bootstrapped = true;
        }
        public static bool Bootstrapped => _bootstrapped;
    }
}
