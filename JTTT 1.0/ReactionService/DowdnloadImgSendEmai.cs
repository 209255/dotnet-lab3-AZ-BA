using System.Linq.Expressions;

namespace JTTT_1._0
{
    class DowdnloadImgSendEmai : IReaction
    {
        private const string ReactionName = "Send Email with Attachment";
        public string GetReactionName()
        {
            return ReactionName;
        }

        public void DoReaction(Model model)
        {
            var myModel = model as MDowdnloadImgSendEmai;
            const string myEmailAddres = "zpompka666@gmail.com";
            const string myPassword = "klop0000";

            string imgPath = FileDownloader.DownloadImg(myModel.ImgURL);

            string emailBody = "Masz mości Panie swój obrazek";
            string subject = "Very important message";
            IEmailService emailService = new SMTPService(gmailConfig.server, gmailConfig.port, myEmailAddres, myPassword);
            SingleMsgWithAttachment msgA = new SingleMsgWithAttachment(myEmailAddres, myModel.EmailReceiverAddress, imgPath, subject, emailBody);
            emailService.Send(msgA);
        }

        public DowdnloadImgSendEmai()
        {
            Services.Instance.ReactionRegister.RegisterReaction(this);
        }

        public Model GetEmptyModel()
        {
            return new MDowdnloadImgSendEmai();
        }
    }
}