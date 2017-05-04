﻿using Eve;
using Newtonsoft.Json;
using SQLite.Net.Attributes;
using System;

namespace Amica.Models
{
	public abstract class BaseModel : ObservableObject, IDataErrorInfo
	{
		private string _uniqueId, _etag;
		private DateTime _updated, _created;
		private bool _deleted;

		/// <summary>
		/// Gets or sets the unique Id.
		/// </summary>
		/// <value>The unique identifier.</value>
		[JsonProperty ("_id")]
		[Remote (Meta.DocumentId)]
		[PrimaryKey]
		public string UniqueId {
			set { SetProperty (ref _uniqueId, value); }
			get { return _uniqueId; }
		}

		/// <summary>
		/// Gets or sets the ETag.
		/// </summary>
		/// <value>The ETag.</value>
		[JsonProperty ("_etag")]
		[Remote (Meta.ETag)]
		[NotNull]
		public string ETag {
			set { SetProperty (ref _etag, value); }
			get { return _etag; }
		}

		/// <summary>
		/// Gets or sets the last update date and time.
		/// </summary>
		/// <value>The last updated date and time.</value>
		[JsonProperty ("_updated")]
		[Remote (Meta.LastUpdated)]
		[Indexed][NotNull]
		public DateTime Updated {
			set { SetProperty (ref _updated, value); }
			get { return _updated; }
		}

		/// <summary>
		/// Gets or sets the creation date.
		/// </summary>
		/// <value>The creation date.</value>
		[JsonProperty ("_created")]
		[Remote (Meta.DateCreated)]
		[Indexed][NotNull]
		public DateTime Created {
			set { SetProperty (ref _created, value); }
			get { return _created; } 
		}

		/// <summary>
		/// Gets or set the deleted status.
		/// </summary>
		/// <value>The creation date.</value>
		[JsonProperty ("_deleted")]
		[Remote (Meta.DateCreated)]
		public bool Deleted {
			set { SetProperty (ref _deleted, value); }
			get { return _deleted; } 
		}

	    public string Error => null;

	    public string this[string columnName] => null;
	}
}