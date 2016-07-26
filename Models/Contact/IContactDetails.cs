using System;
using System.Collections.Generic;
using System.Text;

namespace Amica.vNext.Models
{
    public interface IContactDetails
    {
		string Mail { get; set; }
		string Phone { get; set; }
		string WebSite { get; set; }
		string PecMail { get; set; }
		string Mobile { get; set; }
		string Fax { get; set; }
    }
}
