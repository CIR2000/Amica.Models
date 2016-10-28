using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amica.Models
{
    public interface IDataErrorInfo
    {
		string Error { get; }
		string this[string columnName] { get; }
    }
}
