using Eve;
using Newtonsoft.Json;
using SQLite.Net.Attributes;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Amica.vNext.Models
{
	public abstract class BaseModel : INotifyPropertyChanged
	{
		private string _uniqueId, _etag;
		private DateTime _updated, _created;

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

		#region "INotifyPropertyChanged implementation"

		public event PropertyChangedEventHandler PropertyChanged;

		// ReSharper disable once UnusedMethodReturnValue.Local
		protected bool SetProperty<T> (ref T storage, T value, [CallerMemberName] string propertyName = null)
		{
			if (Equals (storage, value))
				return false;

			storage = value;
			OnPropertyChanged (propertyName);
			return true;
		}

		protected virtual void OnPropertyChanged (string propertyName)
		{
			var handler = PropertyChanged;
			if (handler != null)
				handler (this, new PropertyChangedEventArgs (propertyName));
		}

		#endregion
	}
}
