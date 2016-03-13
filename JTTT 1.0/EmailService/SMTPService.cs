using System;
using System.Net;
using System.Net.Mail;

namespace JTTT_1._0
{
    class SMTPService : IEmailService
    {
        const string DefaultSmtpOutServer = "smtp.gmail.com";
        const int DefaultPort = 587;
        public static readonly string DefaultEmailSender = "zpompka666@gmail.com";
        readonly string defaultPassword = "klop0000";

        public void Send(EmailMsg message)
        {
            SmtpClient client = new SmtpClient(DefaultSmtpOutServer, DefaultPort)
            {
                Credentials = new NetworkCredential(DefaultEmailSender, defaultPassword),
                EnableSsl = true
            };

            try 
            {
                client.Send(message.message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
