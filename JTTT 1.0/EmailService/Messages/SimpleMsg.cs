using System.Net.Mail;

namespace JTTT_1._0
{
    class SimpleMsg : EmailMsg
    {
        public SimpleMsg(string senderEmail, string receiverEmail, string subject, string body)
        {
            Message = new MailMessage(senderEmail, receiverEmail);
            AddSubjectAndBody(subject, body);
        }
    }
}
