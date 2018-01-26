using Newtonsoft.Json;

namespace Amica.Models
{
    /// <summary>
    /// Contact details.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    /// <seealso cref="Amica.Models.IContactDetails" />
    public class ContactDetails : ObservableObject, IContactDetails
    {
        private string _phone;
        private string _mobile;
        private string _fax;
        private string _mail;
        private string _pecMail;
        private string _webSite;
        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        public string Phone
        {
            get { return _phone; }
            set { SetProperty(ref _phone, value); }
        }
        /// <summary>
        /// Gets or sets the mobile.
        /// </summary>
        /// <value>
        /// The mobile.
        /// </value>
        public string Mobile
        {
            get { return _mobile; }
            set { SetProperty(ref _mobile, value); }
        }
        /// <summary>
        /// Gets or sets the fax.
        /// </summary>
        /// <value>
        /// The fax.
        /// </value>
        public string Fax
        {
            get { return _fax; }
            set { SetProperty(ref _fax, value); }
        }
        /// <summary>
        /// Gets or sets the mail.
        /// </summary>
        /// <value>
        /// The mail.
        /// </value>
        public string Mail
        {
            get { return _mail; }
            set { SetProperty(ref _mail, value); }
        }
        /// <summary>
        /// Gets or sets the PEC mail.
        /// </summary>
        /// <value>
        /// The PEC mail.
        /// </value>
        [JsonProperty("pec_mail")]
        public string PecMail
        {
            get { return _pecMail; }
            set { SetProperty(ref _pecMail, value); }
        }
        /// <summary>
        /// Gets or sets the web site.
        /// </summary>
        /// <value>
        /// The web site.
        /// </value>
        [JsonProperty("web_site")]
        public string WebSite
        {
            get { return _webSite; }
            set { SetProperty(ref _webSite, value); }
        }
    }
}
