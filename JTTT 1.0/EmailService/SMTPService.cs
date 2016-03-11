using System;
using System.Net;
using System.Net.Mail;

namespace JTTT_1._0
{
    class SMTPService
    {
        readonly string defaultSmtpOutServer = "smtp.gmail.com";
        readonly int defaultPort = 587;
        public static readonly string defaultEmailSender = "zpompka666@gmail.com";
        readonly string defaultPassword = "klop0000";

        public void SendEmailWithAttachment(string receiverEmail, string attachmentFile)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(defaultEmailSender, defaultPassword),
                EnableSsl = true
            };
            SingleMsgWithAttachment msg = new SingleMsgWithAttachment(receiverEmail, attachmentFile);

            try {
                client.Send(msg.message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SendSimpleEmail(string receiverEmail, string topic)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(defaultEmailSender, defaultPassword),
                EnableSsl = true
            };
            SimpleMsg msg = new SimpleMsg(receiverEmail, topic);
            try
            {
                client.Send(msg.message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
