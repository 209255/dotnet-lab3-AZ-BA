using System;

namespace JTTT_1._0
{
    [Serializable]
    class DownloadAndDisplay : IReaction
    {
        public string ReactionName { get; set; } = "Display image";
        public override string GetReactionName()
        {
            return ReactionName;
        }

        public override void DoReaction(IModel model)
        {
            var myModel = model as MDowdnloadImgSendEmai;
            string imgPath = FileDownloader.DownloadImg(myModel.ImgURL);

            string description = myModel.Description;

            DisplayForm form = new DisplayForm();
            form.SetDescription(myModel.Description);
            form.SetImg(imgPath);
            form.Show();

        }

        public override IModel GetEmptyModel()
        {
            return new MDowdnloadImgSendEmai();
        }

        public override ReactionView GetView()
        {
            return new VDownloadAndDisplay();
        }

        public DownloadAndDisplay()
        {
            Services.Instance.ReactionRegister.RegisterReaction(this);
        }
    }
}
