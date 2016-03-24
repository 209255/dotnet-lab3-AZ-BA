using System;

namespace JTTT_1._0
{ 
    class FindImgByKeyInDescription : IAction
    {

        private const string ActionName = "Find key word in desription -> email";
        public string DoAction(Model model)
        {
            var myModel = model as MFindImgByKeyInDescription;
            Services.Instance.Logger.AddAction(ActionName  + "\t" +  myModel.URL + "\t" + myModel.KeyWord);

            var htmlService = Services.Instance.Htmlservice;

            string path = htmlService.GetPctUrl(myModel.URL.Contains("http://") ? myModel.URL : "http://" + myModel.URL,
                                      myModel.KeyWord);
            FileDownloader.DownloadImg(path);
   
            string fileAtt = "obrazek.jpg";
            return fileAtt;
        }

        public string GetActionName()
        {
            return ActionName;
        }

        public FindImgByKeyInDescription()
        {
            Services.Instance.ActionRegister.RegisterAction(this);
        }

        public Model GetEmptyModel()
        {
            return new MFindImgByKeyInDescription();
        }
    }
}
