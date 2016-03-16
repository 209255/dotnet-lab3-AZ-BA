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
        string GetPageHtml(string url)
        {
            
            using (var wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var html = WebUtility.HtmlDecode(wc.DownloadString(url));
                return html;
            }
            
        }

        public string GetPctUrl(string url,  string keyWord)
        {
            var doc = new HtmlDocument();
            var pageHtml = GetPageHtml(url);
            doc.LoadHtml(pageHtml);
            var nodes = doc.DocumentNode.Descendants("img");
            return (from node in nodes 
                    let alt = node.GetAttributeValue("alt", "") 
                    let src = node.GetAttributeValue("src", "")
                    where alt.ToLower().Contains(keyWord.ToLower()) select src).FirstOrDefault();
        }

      
    }
}
