using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amica.Models.Company
{
    public class EmailAttachment : ObservableObject
    {
        string _username, _password, _smpt, _protocol, _body;
        int _port;
		public string Username {
			set { SetProperty (ref _username, value); }
			get { return _username; } 
		}
		public string Password {
			set { SetProperty (ref _password, value); }
			get { return _password; } 
		}
		public string Smpt {
			set { SetProperty (ref _smpt, value); }
			get { return _smpt; } 
		}
		public string Protocol {
			set { SetProperty (ref _protocol, value); }
			get { return _protocol; } 
		}
		public int Port {
			set { SetProperty (ref _port, value); }
			get { return _port; } 
		}
        [JsonProperty("email_attachment")]
		public string MessageBody {
			set { SetProperty (ref _body, value); }
			get { return _body; } 
		}
    }
}
