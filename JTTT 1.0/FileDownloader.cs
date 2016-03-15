using System;
using System.Net;


namespace JTTT_1._0
{
    public static class FileDownloader
    {
       static public string DownloadImg(string src)
        {
             var filepath = "obrazek.jpg";
            using (var wc = new WebClient())
            {
                try {
                    wc.DownloadFile(src, filepath);
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine("Cannot download image from " + src);
                }
            }
             return filepath;
        }
    }
}
