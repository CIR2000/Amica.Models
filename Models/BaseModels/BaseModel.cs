using Eve;
using Newtonsoft.Json;
using System;

namespace Amica.Models
{
    /// <summary>
    /// Base class to be inherited by all concrete data models.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    /// <seealso cref="Amica.Models.IDataErrorInfo" />
    public abstract class BaseModel : ObservableObject, IDataErrorInfo
	{
		private string _uniqueId, _etag;
		private DateTime _updated, _created;
		private bool _deleted;

		/// <summary>
		/// Gets or sets the unique identifier.
		/// </summary>
		/// <value>The unique identifier.</value>
		[JsonProperty ("_id")]
		[Remote (Meta.DocumentId)]
		public string UniqueId {
			set { SetProperty (ref _uniqueId, value); }
			get { return _uniqueId; }
		}

		/// <summary>
		/// Gets or sets the ETag.
		/// </summary>
		/// <value>The ETag.</value>
		[Remote (Meta.ETag)]
		public string Etag {
			set { SetProperty (ref _etag, value); }
			get { return _etag; }
		}

		/// <summary>
		/// Gets or sets the last update date and time.
		/// </summary>
		/// <value>The last updated date and time.</value>
		[Remote (Meta.LastUpdated)]
		public DateTime Updated {
			set { SetProperty (ref _updated, value); }
			get { return _updated; }
		}

		/// <summary>
		/// Gets or sets the creation date.
		/// </summary>
		/// <value>The creation date.</value>
		[Remote (Meta.DateCreated)]
		public DateTime Created {
			set { SetProperty (ref _created, value); }
			get { return _created; } 
		}

		/// <summary>
		/// Gets or set the deleted status.
		/// </summary>
		/// <value>The creation date.</value>
		[Remote (Meta.DateCreated)]
		public bool Deleted {
			set { SetProperty (ref _deleted, value); }
			get { return _deleted; } 
		}

        /// <summary>
        /// Gets the error.
        /// </summary>
        /// <value>
        /// The error.
        /// </value>
        public string Error => null;

        /// <summary>
        /// Gets the <see cref="System.String"/> with the specified column name.
        /// </summary>
        /// <value>
        /// The <see cref="System.String"/>.
        /// </value>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        public string this[string columnName] => null;
	}
}
