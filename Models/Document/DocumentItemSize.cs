using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Amica.vNext.Models.Documents
{
    public class DocumentItemSize : ObservableObject
    {
        private string _name;
        private string _size;


        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        public string Number
        {
            set { SetProperty(ref _size, value); }
            get { return _size; }
        }
    }
}
