using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;

namespace JTTT_1._0
{
    class HtmlService:IAction
    {
        private readonly string _url ;
        private readonly string _keyWord;
        private List<string> _pcturl 
        {
            get { return _pcturl; }
        }
        public HtmlService(string url, string word)
        {
            _url = url.StartsWith("http://") ? url : "http://" + url;
            _keyWord =  word.ToLower();
        }
        private string GetPageHtml()
        {
            using (var wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var html = WebUtility.HtmlDecode(wc.DownloadString(_url));
                return html;
            }
        }

        private void GetPctUrl()
        {
            var doc = new HtmlDocument();
            var pageHtml = GetPageHtml();
            doc.LoadHtml(pageHtml);
            var nodes = doc.DocumentNode.Descendants("img");
            foreach (var src in from node in nodes let alt 
             = node.GetAttributeValue("alt", "") let src = node.GetAttributeValue("src", "")
             where alt.ToLower().Contains(_keyWord) select src)
            {
                _pcturl.Add(src);
            }
        }

        public void CheckCondition()
        {
            GetPctUrl();
        }
    }
}
