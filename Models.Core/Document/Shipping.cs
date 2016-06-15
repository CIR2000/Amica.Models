using System;
using System.Collections.Generic;
using System.Text;

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

    }
}
