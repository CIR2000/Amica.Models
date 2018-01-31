using Newtonsoft.Json;

namespace Amica.Models.Company
{
    /// <summary>
    /// An email attachment.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class EmailAttachment : ObservableObject
    {
        string _username, _password, _smpt, _protocol, _body;
        int _port;
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string Username {
			set { SetProperty (ref _username, value); }
			get { return _username; } 
		}
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password {
			set { SetProperty (ref _password, value); }
			get { return _password; } 
		}
        /// <summary>
        /// Gets or sets the SMPT address.
        /// </summary>
        /// <value>
        /// The SMPT address.
        /// </value>
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
        public int Port {
			set { SetProperty (ref _port, value); }
			get { return _port; } 
		}
        /// <summary>
        /// Gets or sets the message body.
        /// </summary>
        /// <value>
        /// The message body.
        /// </value>
		public string MessageBody {
			set { SetProperty (ref _body, value); }
			get { return _body; } 
		}
    }
}
