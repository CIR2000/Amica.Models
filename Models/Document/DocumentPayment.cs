using System;
using Newtonsoft.Json;

namespace Amica.Models.Documents
{
    public class DocumentPayment : ObservableObject
    {
        private Payment _payment;
        private DateTime _baseDateForPayments;

		public DocumentPayment() { }

        public Payment Current
        {
            set { SetProperty(ref _payment, value); }
            get { return _payment; }
        }

		/// <summary>
        /// Only used when Document.Payment.FirstPaymentDate is set to ExplicitDate.
        /// </summary>
        public DateTime BaseDateForPayments
        {
            set { SetProperty(ref _baseDateForPayments, value); }
            get { return _baseDateForPayments; }
        }
    }
}
