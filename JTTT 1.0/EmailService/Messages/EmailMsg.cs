using System.Net.Mail;

namespace JTTT_1._0
{
    public class EmailMsg
    {
        public MailMessage Message { get; protected set; }

        protected void AddSubjectAndBody(string subject, string body)
        {
            Message.Subject = subject;
            Message.Body = body;
        }
    }
}
