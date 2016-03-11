using System.Net.Mail;

namespace JTTT_1._0
{
    public class EmailMsg
    {
        public MailMessage message { get; protected set; }

        protected void AddSubjectAndBody(string subject, string body)
        {
            message.Subject = subject;
            message.Body = body;
        }
    }
}
