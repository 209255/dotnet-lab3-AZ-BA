using System;

namespace JTTT_1._0
{ 
    [Serializable]
    class FindImgByKeyInDescription : IAction
    {

        public string ActionName { get; set; } = "Find image with key word in description";

        public override string DoAction(IModel model)
        {

            var myModel = model as MFindImgByKeyInDescription;
            Services.Instance.Logger.AddAction(ActionName + "\t" + myModel.URL + "\t" + myModel.KeyWord);

            var htmlService = Services.Instance.Htmlservice;

            string imgUrl = htmlService.GetPctUrl(myModel.URL.Contains("http://") ? myModel.URL : "http://" + myModel.URL,
                                      myModel.KeyWord);
            //FileDownloader.DownloadImg(path);
   
            //string fileAtt = "obrazek.jpg";
            return imgUrl;
        }

        public override string GetActionName()
        {
            return ActionName;
        }

        public FindImgByKeyInDescription()
        {
            Services.Instance.ActionRegister.RegisterAction(this);
        }

        public override IModel GetEmptyModel()
        {
            return new MFindImgByKeyInDescription();
        }
    }
}
