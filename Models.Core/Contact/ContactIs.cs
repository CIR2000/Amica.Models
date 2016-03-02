using Newtonsoft.Json;

namespace Amica.vNext.Models
{
    public class ContactIs : ObservableObject
    {
        private bool _active = true;
        private bool _company = true;
        private bool _client;
        private bool _vendor;
        private bool _courier;
        private bool _agent;
        private bool _areaManager;

        public bool Active
        {
            set { SetProperty(ref _active, value); }
            get { return _active; }
        }
        public bool Company
        {
            set { SetProperty(ref _company, value); }
            get { return _company; }
        }

        public bool Client
        {
            set { SetProperty(ref _client, value); }
            get { return _client; }
        }

        public bool Vendor
        {
            set { SetProperty(ref _vendor, value); }
            get { return _vendor; }
        }

        public bool Courier
        {
            set { SetProperty(ref _courier, value); }
            get { return _courier; }
        }

        public bool Agent
        {
            set { SetProperty(ref _agent, value); }
            get { return _agent; }
        }

		[JsonProperty("area_manager")]
        public bool AreaManager
        {
            set { SetProperty(ref _areaManager, value); }
            get { return _areaManager; }
        }
    }
}
