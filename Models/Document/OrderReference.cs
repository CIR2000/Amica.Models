using System;
using Newtonsoft.Json;

namespace Amica.Models.Documents
{
    public class OrderReference : ObservableObject
    {
        private DocumentNumber _number;
        private DateTime _date;
        private string _itemId;

        public DocumentNumber Number
        {
            set { SetProperty(ref _number, value); }
            get { return _number; }
        }

        public DateTime Date
        {
            set { SetProperty(ref _date, value); }
            get { return _date; }
        }

		[JsonProperty("item_id")]
        public string ItemId
        {
            set { SetProperty(ref _itemId, value); }
            get { return _itemId; }
        }
    }
}
