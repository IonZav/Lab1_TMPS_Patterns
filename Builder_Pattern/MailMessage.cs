using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    class MailMessage
    {
        public string From { get; private set; }
        public List<string> To { get; private set; }
        public string Subject { get; private set; }
        public string Body { get; private set; }
        public string AttachementPath { get; private set; }

        public MailMessage()
        {
            To = new List<string>();
        }

        public static MailMessageBuilder With()
        {
            return new MailMessageBuilder();
        }

        public class MailMessageBuilder
        {
            private readonly MailMessage _mailMessage = new MailMessage();

            public MailMessageBuilder From(string from)
            {
                _mailMessage.From = from;
                return this;
            }
            public MailMessageBuilder Subject(string subject)
            {
                _mailMessage.Subject = subject;
                return this;
            }
            public MailMessageBuilder Body(string body)
            {
                _mailMessage.Body = body;
                return this;
            }
            public MailMessageBuilder AttachementPath(string attachementpath)
            {
                _mailMessage.AttachementPath = attachementpath;
                return this;
            }

            public MailMessageBuilder To(string to)
            {
                _mailMessage.To.Add(to);
                return this;
            }

            public MailMessage Build()
            {
                if (_mailMessage.To.Count == 0)
                    throw new InvalidOperationException("Call To method first!");
                return _mailMessage;
            }


        }
    }
}
