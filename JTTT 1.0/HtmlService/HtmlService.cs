using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using System.Net;

namespace JTTT_1._0
{
    public class HtmlService
    {
        private readonly string _url;

        public HtmlService(string url)
        {
            this._url = url;
        }
      
        public string GetPageHtml()
        {
            
            using (var wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var html = WebUtility.HtmlDecode(wc.DownloadString(_url));
                return html;
            }
            
        }

        public string GetPctUrl(string keyWord)
        {
            string path = null;
            var doc = new HtmlDocument();
            var pageHtml = GetPageHtml();
            doc.LoadHtml(pageHtml);
            var nodes = doc.DocumentNode.Descendants("img");
            foreach (var node in nodes)
            {
                var alt = node.GetAttributeValue("alt", "");
                var src = node.GetAttributeValue("src", "");
                if (alt.ToLower().Contains(keyWord.ToLower()))
                 {
                   path = src;
                   Console.WriteLine("Znalazlem!!!!!!!!!!!!!!!@@@@@");
                     break;
                 }
               
            }
            Console.WriteLine("nie znalazlem Znalazlem!!!!!!!!!!!!!!!@@@@@");
            return path;
        }

      
    }
}
