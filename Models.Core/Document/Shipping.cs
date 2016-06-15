using System;

namespace Amica.vNext.Models.Documents
{
    public class Shipping : ObservableObject
    {
        private int _volume;
        private string _unitOfMeasure;
        private double _weight;
        private string _appearance;
        private DateTime _dateTime;
        private ContactDetailsEx _courier;
        private TransportMode _transportMode;
        private Driver _driver;
        private ShippingTerm _shippingTerms;

        public int Volume
        {
            set { SetProperty(ref _volume, value); }
            get { return _volume; }
        }
        public string UnitOfMeasure
        {
            set { SetProperty(ref _unitOfMeasure, value); }
            get { return _unitOfMeasure; }
        }
        public double Weight
        {
            set { SetProperty(ref _weight, value); }
            get { return _weight; }
        }
        public string Appearance
        {
            set { SetProperty(ref _appearance, value); }
            get { return _appearance; }
        }
        public DateTime DateTime
        {
            set { SetProperty(ref _dateTime, value); }
            get { return _dateTime; }
        }
        public ContactDetailsEx Courier
        {
            set { SetProperty(ref _courier, value); }
            get { return _courier; }
        }
        public TransportMode TransportMode
        {
            set { SetProperty(ref _transportMode, value); }
            get { return _transportMode; }
        }
        public Driver Driver
        {
            set { SetProperty(ref _driver, value); }
            get { return _driver; }
        }
        public ShippingTerm Terms
        {
            set { SetProperty(ref _shippingTerms, value); }
            get { return _shippingTerms; }
        }
    }
}
