using System.Net.Mail;

namespace JTTT_1._0
{
    class SimpleMsg : EmailMsg
    {
        public SimpleMsg(string receiverEmail, string subject, string body)
        {
            Message = new MailMessage(SMTPService.DefaultEmailSender, receiverEmail);
            AddSubjectAndBody(subject, body);
        }
    }
}
