using System;
using System.Linq;
using System.Net;


namespace JTTT_1._0
{
    public static class FileDownloader
    {
       static public string DownloadImg(string src)
        {
             var filepath = "obrazek.jpg";
             using (var wc = new WebClient() )
                 wc.DownloadFile(src,filepath);
             return filepath;
        }
    }
}
