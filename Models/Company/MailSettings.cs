using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Amica.Models.Company
{
    /// <summary>
    /// Company's mail settings.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class MailSettings : ObservableObject
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
        [Display(Name = nameof(Resources.PropertyNames.SmptAddress), ResourceType = typeof(Resources.PropertyNames))]
        public string SmptAddress {
			set { SetProperty (ref _smpt, value); }
			get { return _smpt; } 
		}
        /// <summary>
        /// Gets or sets the protocol.
        /// </summary>
        /// <value>
        /// The protocol.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.Protocol), ResourceType = typeof(Resources.PropertyNames))]
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
        [Display(Name = nameof(Resources.PropertyNames.Port), ResourceType = typeof(Resources.PropertyNames))]
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
        [Display(Name = nameof(Resources.PropertyNames.Templates), ResourceType = typeof(Resources.PropertyNames))]
        public List<MailTemplate> Template { get; } 
    }
}
