using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Amica.Models.Documents
{
    public class DocumentItemDetail : ObservableObject
    {
        private string _sku;
        private string _description;
        private string _unitOfMeasure;
        private string _serial;
        private string _color;
        private string _notes;
        private DocumentItemSize _size;
        private DocumentItemLot _lot;


        public string Sku
        {
            set { SetProperty(ref _sku, value); }
            get { return _sku; }
        }

		public string Description {
			set { SetProperty (ref _description, value); }
			get { return _description; }
		}
		[JsonProperty ("unit_of_measure")]
        public string UnitOfMeasure
        {
            set { SetProperty(ref _unitOfMeasure, value); }
            get { return _unitOfMeasure; }
        }

		[JsonProperty("serial_number")]
        public string SerialNumber
        {
            set { SetProperty(ref _serial, value); }
            get { return _serial; }
        }

        public string Color
        {
            set { SetProperty(ref _color, value); }
            get { return _color; }
        }

        public string Notes
        {
            set { SetProperty(ref _notes, value); }
            get { return _notes; }
        }

        public DocumentItemSize Size
        {
            set { SetProperty(ref _size, value); }
            get { return _size; }
        }

        public DocumentItemLot Lot
        {
            set { SetProperty(ref _lot, value); }
            get { return _lot; }
        }
    }
}
