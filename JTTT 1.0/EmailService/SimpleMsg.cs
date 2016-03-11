using System;
using System.Net.Mail;

namespace JTTT_1._0
{
    class SimpleMsg : EmailMsg
    {
        public MailMessage message { get; private set; }

        public SimpleMsg(string receiverEmail, string topic)
        {
            message = new MailMessage(SMTPService.defaultEmailSender, receiverEmail);
            message.Subject = topic;
            message.Body = topic;
        }
    }
}
