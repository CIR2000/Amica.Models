using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Amica.Models
{
    /// <summary>
    /// Company's mail settings.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class MailSettings : BaseModelWithCompanyId
    {
        string _smpt, _protocol;
        int _port;
        /// <summary>
        /// Initializes a new instance of the <see cref="MailSettings"/> class.
        /// </summary>
        public MailSettings()
        {
            Template = new List<MailTemplate>();
        }

        /// <summary>
        /// Gets or sets the SMPT address.
        /// </summary>
        /// <value>
        /// The SMPT address.
        /// </value>
        [Display(Name = nameof(Resources.Properties.SmptAddress), ResourceType = typeof(Resources.Properties))]
        public string SmtpAddress {
			set { SetProperty (ref _smpt, value); }
			get { return _smpt; } 
		}
        /// <summary>
        /// Gets or sets the protocol.
        /// </summary>
        /// <value>
        /// The protocol.
        /// </value>
        [Display(Name = nameof(Resources.Properties.Protocol), ResourceType = typeof(Resources.Properties))]
        public string Protocol {
			set { SetProperty (ref _protocol, value); }
			get { return _protocol; } 
		}
        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        /// <value>
        /// The port.
        /// </value>
        [Display(Name = nameof(Resources.Properties.Port), ResourceType = typeof(Resources.Properties))]
        public int Port {
			set { SetProperty (ref _port, value); }
			get { return _port; } 
		}
        /// <summary>
        /// Gets email templates.
        /// </summary>
        /// <value>
        /// The email templates.
        /// </value>
        [Display(Name = nameof(Resources.Properties.Templates), ResourceType = typeof(Resources.Properties))]
        [JsonProperty("templates")]
        public List<MailTemplate> Template { get; } 
    }
}
