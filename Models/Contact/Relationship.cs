using Newtonsoft.Json;

namespace Amica.Models
{
    /// <summary>
    /// Informations on the contact relationship.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class Relationship : ObservableObject
    {
        private bool _active = true;
        private bool _company = true;
        private bool _client;
        private bool _vendor;
        private bool _courier;
        private bool _agent;
        private bool _areaManager;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive
        {
            set { SetProperty(ref _active, value); }
            get { return _active; }
        }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is company.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is company; otherwise, <c>false</c>.
        /// </value>
        public bool IsCompany
        {
            set { SetProperty(ref _company, value); }
            get { return _company; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is client.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is client; otherwise, <c>false</c>.
        /// </value>
        public bool IsClient
        {
            set { SetProperty(ref _client, value); }
            get { return _client; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is vendor.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is vendor; otherwise, <c>false</c>.
        /// </value>
        public bool IsVendor
        {
            set { SetProperty(ref _vendor, value); }
            get { return _vendor; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is courier.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is courier; otherwise, <c>false</c>.
        /// </value>
        public bool IsCourier
        {
            set { SetProperty(ref _courier, value); }
            get { return _courier; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is agent.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is agent; otherwise, <c>false</c>.
        /// </value>
        public bool IsAgent
        {
            set { SetProperty(ref _agent, value); }
            get { return _agent; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is area manager.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is area manager; otherwise, <c>false</c>.
        /// </value>
        public bool IsAreaManager
        {
            set { SetProperty(ref _areaManager, value); }
            get { return _areaManager; }
        }
    }
}