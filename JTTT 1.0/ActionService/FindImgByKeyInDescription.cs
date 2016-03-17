using System;

namespace JTTT_1._0
{ 
    class FindImgByKeyInDescription : IAction
    {
        const string actionName = "Find key word in desription -> email";

        public string DoAction(string url, string key)
        {
            Services.Instance.logger.AddAction(actionName  + "\t" + url + "\t" + key);

            var htmlService = Services.Instance.htmlservice;

            string path = htmlService.GetPctUrl(url.Contains("http://") ? url : "http://" + url,
                                      key);
            FileDownloader.DownloadImg(path);
   
            string fileAtt = "obrazek.jpg";
            return fileAtt;
        }

        public string GetActionName()
        {
            return actionName;
        }

        public FindImgByKeyInDescription()
        {
            Services.Instance.actionRegister.RegisterAction(this);
        }
    }
}
