using Newtonsoft.Json;

namespace Amica.vNext.Models
{
    public class AddressEx : Address, IAddressEx
    {
        private string _phone;
        private string _mobile;
        private string _fax;
        private string _mail;
        private string _pecMail;
        private string _webSite;
        public string Phone
        {
            get { return _phone; }
            set { SetProperty(ref _phone, value); }
        }
        public string Mobile
        {
            get { return _mobile; }
            set { SetProperty(ref _mobile, value); }
        }
        public string Fax
        {
            get { return _fax; }
            set { SetProperty(ref _fax, value); }
        }
        public string Mail
        {
            get { return _mail; }
            set { SetProperty(ref _mail, value); }
        }
		[JsonProperty("pec_mail")]
        public string PecMail
        {
            get { return _pecMail; }
            set { SetProperty(ref _pecMail, value); }
        }
		[JsonProperty("web_site")]
        public string WebSite
        {
            get { return _webSite; }
            set { SetProperty(ref _webSite, value); }
        }
    }
}
