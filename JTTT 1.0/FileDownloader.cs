using System;
using System.Net;


namespace JTTT_1._0
{
    public static class FileDownloader
    {
       public static string DownloadImg(string src)
        {
            const string filepath = "obrazek.jpg";
            using (var wc = new WebClient())
            {
                try {
                    Console.WriteLine(src);
                    wc.DownloadFile(src, filepath);
                    Console.WriteLine("download@@@@");
                }
                catch (Exception e)
                {
                    Console.WriteLine("nicht download@@@@@@@@@@@");
                    Console.WriteLine("Cannot download image from " + src);
                }
            }
             return filepath;
        }
    }
}
