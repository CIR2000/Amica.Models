using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amica.Models
{
    /// <summary>
    /// Data binding interface.
    /// </summary>
    public interface IDataErrorInfo
    {
        /// <summary>
        /// Gets the error.
        /// </summary>
        /// <value>
        /// The error.
        /// </value>
        string Error { get; }
        /// <summary>
        /// Gets the <see cref="System.String"/> with the specified column name.
        /// </summary>
        /// <value>
        /// The <see cref="System.String"/>.
        /// </value>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        string this[string columnName] { get; }
    }
}
