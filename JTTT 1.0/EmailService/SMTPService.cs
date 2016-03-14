using System;
using System.Net;
using System.Net.Mail;

namespace JTTT_1._0
{
    class SMTPService : IEmailService
    {
        string smtpOutServer;
        int port;
        string emailAddress;
        string password;

        public void Send(EmailMsg message)
        {
            SmtpClient client = new SmtpClient(smtpOutServer, port)
            {
                Credentials = new NetworkCredential(emailAddress, password),
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

        public SMTPService(string smtpOutServer, int port, string emailAddress, string password)
        {
            this.smtpOutServer = smtpOutServer;
            this.port = port;
            this.emailAddress = emailAddress;
            this.password = password;
        }
    }
}
