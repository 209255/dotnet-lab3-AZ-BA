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
        
        public string Pcturl
        {
            get { return Pcturl; }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                Pcturl = value;
            }
        }

        public string GetPageHtml(string url)
        {
            Console.WriteLine("wchodze!!!!!!!!!!!!!!!!!@@@@@@@@@@@@2");
            using (var wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var html = WebUtility.HtmlDecode(wc.DownloadString(url));
                Console.WriteLine("wczutalem");
                return html;
            }
            
        }

        public void GetPctUrl(string url, string keyWord)
        {
            var doc = new HtmlDocument();
            var pageHtml = GetPageHtml(url);
            doc.LoadHtml(pageHtml);
            var nodes = doc.DocumentNode.Descendants("img");
            foreach (var node in nodes)
            {
                var alt = node.GetAttributeValue("alt", "");
                var src = node.GetAttributeValue("src", "");
                if (alt.ToLower().Contains(keyWord))
                 {
                    Pcturl = src;
                    Console.WriteLine("Znalazlem!!!!!!!!!!!!!!!@@@@@");
                     break;
                 }
               
            }
            Console.WriteLine("nie znalazlem Znalazlem!!!!!!!!!!!!!!!@@@@@");
        }

      
    }
}
