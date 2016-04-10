using System.Linq;
using System.Text;
using HtmlAgilityPack;
using System.Net;

namespace JTTT_1._0
{
    public class HtmlService
    {
        private static string GetPageHtml(string url)
        {
            if (url == null) return null;
            using (var wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var html = WebUtility.HtmlDecode(wc.DownloadString(url));
                return html;
            }
            
        }

        public string[] GetPctUrlWithDescription(string url,  string keyWord)
        {
            var doc = new HtmlDocument();
            var pageHtml = GetPageHtml(url);
            if (pageHtml == null) return null;
            doc.LoadHtml(pageHtml);
            var nodes = doc.DocumentNode.Descendants("img");
            var myNode = (from node in nodes 
                    let alt = node.GetAttributeValue("alt", "") 
                    let src = node.GetAttributeValue("src", "")
                    where alt.ToLower().Contains(keyWord.ToLower()) select node).FirstOrDefault();
            if (myNode == null)
                return null;
            return new string[] { myNode.GetAttributeValue("src", ""), myNode.GetAttributeValue("alt", "") };
        }

      
    }
}
