using System;

namespace Amica.vNext.Models.Documents
{
    public class DocumentItemLot : ObservableObject
    {
        private string _number;
        private DateTime _date;
        private DateTime _expiration;

        public string Number
        {
            set { SetProperty(ref _number, value); }
            get { return _number; }
        }

		public DateTime Date {
			set { SetProperty (ref _date, value); }
			get { return _date; }
		}
        public DateTime Expiration
        {
            set { SetProperty(ref _expiration, value); }
            get { return _expiration; }
        }
    }
}
