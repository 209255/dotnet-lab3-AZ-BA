using System.Net.Mail;
using System.Net.Mime;

namespace JTTT_1._0
{
    class SingleMsgWithAttachment : EmailMsg
    {
        public MailMessage message { get; private set; }

        public SingleMsgWithAttachment(string receiverEmail, string file)
        {
            message = new MailMessage(SMTPService.defaultEmailSender, receiverEmail);
            message.Attachments.Add(LoadAtatchment(file));
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
