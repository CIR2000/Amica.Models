using System;

namespace Amica.Models.Documents
{
    public class DocumentItemLot : ObservableObject
    {
        private string _number;
        private DateTime _date;
        private DateTime _expiration;

		public DocumentItemLot()
        {
			// TODO these minvalues are needed for Adam. Must find a general solution.
			// Consider handling minvalues in Eve.NET
            Date = new DateTime(1900, 1, 1);
            Expiration = new DateTime(1900,1,1);
        }
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
