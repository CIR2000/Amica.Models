using System;
using System.Collections.Generic;
using System.Text;
using Amica.Models.Documents;
using Amica.Models.ItalianPA;

namespace Amica.Models
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
            Factory<Document>.Register(() => new Document());
            Factory<DocumentFee>.Register(() => new DocumentFee());
            Factory<NaturaPA>.Register(() => new NaturaPA());
            Factory<ModalitaPagamentoPA>.Register(() => new ModalitaPagamentoPA());
            Factory<Currency>.Register(() => new Currency());
            Factory<AddressEx>.Register(() => new AddressEx());
            Factory<Bank>.Register(() => new Bank());
            Factory<ShippingAddress>.Register(() => new ShippingAddress());
            Factory<BillingAddress>.Register(() => new BillingAddress());
            Factory<WithholdingTax>.Register(() => new WithholdingTax());
            Factory<SocialSecurity>.Register(() => new SocialSecurity());
            Factory<Shipping>.Register(() => new Shipping());
            Factory<DocumentItem>.Register(() => new DocumentItem());
            Factory<Warehouse>.Register(() => new Warehouse());
            Factory<Size>.Register(() => new Size());

            _bootstrapped = true;
        }
        public static bool Bootstrapped => _bootstrapped;
    }
}
