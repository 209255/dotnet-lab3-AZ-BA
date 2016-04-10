﻿using System;
using System.Linq.Expressions;

namespace JTTT_1._0
{
    [Serializable]
    class DowdnloadImgSendEmai : IReaction
    {
        
        public string ReactionName { get; set; } = "Send Email with Attachment";
        public override string GetReactionName()
        {
            return ReactionName;
        }

        public override void DoReaction(IModel model)
        {
            var myModel = model as MDowdnloadImgSendEmai;
            const string myEmailAddres = "zpompka666@gmail.com";
            const string myPassword = "klop0000";

            string imgPath = FileDownloader.DownloadImg(myModel.ImgURL);

            string emailBody = myModel.Description;
            string subject = "Very important message";
            IEmailService emailService = new SMTPService(gmailConfig.server, gmailConfig.port, myEmailAddres, myPassword);
            SingleMsgWithAttachment msgA = new SingleMsgWithAttachment(myEmailAddres, myModel.EmailReceiverAddress, imgPath, subject, emailBody);
            emailService.Send(msgA);
        }

        public DowdnloadImgSendEmai()
        {
            Services.Instance.ReactionRegister.RegisterReaction(this);
        }

        public override IModel GetEmptyModel()
        {
            return new MDowdnloadImgSendEmai();
        }
    }
}