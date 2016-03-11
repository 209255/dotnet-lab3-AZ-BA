using System.Net.Mail;
using System.Net.Mime;

namespace JTTT_1._0
{
    class SingleMsgWithAttachment : EmailMsg
    {
        public SingleMsgWithAttachment(string receiverEmail, string filePath, string subject, string body)
        {
            message = new MailMessage(SMTPService.defaultEmailSender, receiverEmail);
            AddSubjectAndBody(subject, body);
            message.Attachments.Add(LoadAtatchment(filePath));
        }

        Attachment LoadAtatchment(string file)
        {
            // Create  the file attachment for this e-mail message.
            Attachment data = new Attachment(file, MediaTypeNames.Application.Octet);
            // Add time stamp information for the file.
            ContentDisposition disposition = data.ContentDisposition;
            disposition.CreationDate = System.IO.File.GetCreationTime(file);
            disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
            disposition.ReadDate = System.IO.File.GetLastAccessTime(file);
            return data;
        }
    }
}
