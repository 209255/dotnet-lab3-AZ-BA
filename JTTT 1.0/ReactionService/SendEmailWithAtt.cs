using System.Linq.Expressions;

namespace JTTT_1._0
{
    public class SendEmailWithAtt : IReaction
    {
        private const string ReactionName = "Send Email with Attachment";
        public string GetReactionName()
        {
            return ReactionName;
        }

        public void DoReaction(string url, string filepath, string emailAdd, string keyword)
        {
           const string myEmailAddres = "zpompka666@gmail.com";
           const string myPassword = "klop0000";

            //string receiverAddres = EmailAdress.Text;
            string emailBody = "To jest obrazek ze strony " + url + " zawierający słowo klucz \"" + keyword + "\"";
            string subject = "Very important message";
            IEmailService emailService = new SMTPService(gmailConfig.server, gmailConfig.port, myEmailAddres, myPassword);
            SingleMsgWithAttachment msgA = new SingleMsgWithAttachment(myEmailAddres, emailAdd, filepath, subject, emailBody);
            emailService.Send(msgA);
        }
    }
}