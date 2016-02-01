using System;
using System.Collections.Generic;
using System.Text;

namespace Amica.vNext.Models
{
    public class Contact : BaseModelWithCompanyId, IContactMinimal
    {
        private string _name;
        private string _address;
        private string _vat;

        /// <summary>
        /// Gets or sets the contact name.
        /// </summary>
        /// <value>The contact name.</value>
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The contact address</value>
        public string Address
        {
            set { SetProperty(ref _address, value); }
            get { return _address; }
        }

        /// <summary>
        /// Gets or sets the VAT number.
        /// </summary>
        /// <value>The VAT number.</value>
        public string Vat
        {
            set { SetProperty(ref _vat, value); }
            get { return _vat; }
        }
    }
}
