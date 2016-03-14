using System;
using System.Linq;
using System.Net;


namespace JTTT_1._0
{
    public static class FileDownloader
    {
        public static string DownloadImg(string src)
        {
             var filepath = System.IO.Path.GetTempPath() + Guid.NewGuid() + ".jpg";
             using (var wc = new WebClient() )
                 wc.DownloadFile(src,filepath);
             return filepath;
        }

        public static string[] DownloadImg(string[] src)
        {
            return src.Select(DownloadImg).ToArray();
        }
    }
}
