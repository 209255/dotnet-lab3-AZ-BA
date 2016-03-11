using System;
using System.Net;
using System.Net.Mail;

namespace JTTT_1._0
{
    class SMTPService : IEmailService
    {
        const string defaultSmtpOutServer = "smtp.gmail.com";
        const int defaultPort = 587;
        public static readonly string defaultEmailSender = "zpompka666@gmail.com";
        readonly string defaultPassword = "klop0000";

        public void Send(EmailMsg message)
        {
            SmtpClient client = new SmtpClient(defaultSmtpOutServer, defaultPort)
            {
                Credentials = new NetworkCredential(defaultEmailSender, defaultPassword),
                EnableSsl = true
            };

            try {
                client.Send(message.message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
