using System;

namespace Amica.vNext.Objects
{
    public abstract class BaseClass
    {
		/// <summary>
		/// Gets or sets the unique Id.
		/// </summary>
		/// <value>The unique identifier.</value>
        public string Id { get; set; }

		/// <summary>
		/// Gets or sets the ETag.
		/// </summary>
		/// <value>The ETag.</value>
        public string ETag { get; set; }

		/// <summary>
		/// Gets or sets the last update date and time.
		/// </summary>
		/// <value>The last updated date and time.</value>
        public DateTime Updated { get; set; }

		/// <summary>
		/// Gets or sets the creation date.
		/// </summary>
		/// <value>The creation date.</value>
        public DateTime Created { get; set; }
    }
}
