using System.ComponentModel.DataAnnotations;

namespace Amica.Models
{
    /// <summary>
    /// An email template.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    public class MailTemplate : ObservableObject
    {
        string _name, _username, _password, _subject, _body, _fromName, _fromAddress;
        int _id;

        /// <summary>
        /// Gets or sets the unique id.
        /// </summary>
        /// <value>
        /// The unique id.
        /// </value>
        public int Id
        {
            set { SetProperty(ref _id, value); }
            get { return _id; }
        }

        /// <summary>
        /// Gets or sets the tempalte name.
        /// </summary>
        /// <value>
        /// The template name.
        /// </value>
        [Display(Name = nameof(Resources.Properties.TemplateName), ResourceType = typeof(Resources.Properties))]
        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        [Display(Name = nameof(Resources.Properties.TemplateSmptUsername), ResourceType = typeof(Resources.Properties))]
        public string SmtpUsername
        {
            set { SetProperty(ref _username, value); }
            get { return _username; }
        }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Display(Name = nameof(Resources.Properties.TemplateSmptPassword), ResourceType = typeof(Resources.Properties))]
        public string SmtpPassword
        {
            set { SetProperty(ref _password, value); }
            get { return _password; }
        }
        /// <summary>
        /// Gets or sets from name.
        /// </summary>
        /// <value>
        /// From name.
        /// </value>
        [Display(Name = nameof(Resources.Properties.TemplateFromName), ResourceType = typeof(Resources.Properties))]
        public string FromName
        {
            set { SetProperty(ref _fromName, value); }
            get { return _fromName; }
        }
        /// <summary>
        /// Gets or sets from address.
        /// </summary>
        /// <value>
        /// From address.
        /// </value>
        [Display(Name = nameof(Resources.Properties.TemplateFromAddress), ResourceType = typeof(Resources.Properties))]
        [EmailAddress()]
        public string FromAddress
        {
            set { SetProperty(ref _fromAddress, value); }
            get { return _fromAddress; }
        }
        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>
        /// The subject.
        /// </value>
        [Display(Name = nameof(Resources.Properties.TemplateMessageSubject), ResourceType = typeof(Resources.Properties))]
        public string MessageSubject
        {
            set { SetProperty(ref _subject, value); }
            get { return _subject; }
        }
        /// <summary>
        /// Gets or sets the message body.
        /// </summary>
        /// <value>
        /// The message body.
        /// </value>
        [Display(Name = nameof(Resources.Properties.TemplateMessageBody), ResourceType = typeof(Resources.Properties))]
        public string MessageBody
        {
            set { SetProperty(ref _body, value); }
            get { return _body; }
        }
    }
}
