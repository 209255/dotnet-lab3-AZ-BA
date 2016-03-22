using System;

namespace JTTT_1._0
{ 
    class FindImgByKeyInDescription : IAction
    {
        private readonly string _keyWord;
        private readonly string _url;
        const string ActionName = "Find key word in desription -> email";
        public string DoAction(string url, string key)
        {
            Services.Instance.Logger.AddAction(ActionName  + "\t" + url + "\t" + key);

            var htmlService = Services.Instance.Htmlservice;

            string path = htmlService.GetPctUrl(url.Contains("http://") ? url : "http://" + url,
                                      key);
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
    }
}
