using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;


namespace JTTT_1._0
{
    public partial class HtmlService : UserControl
    {
        private readonly string _url;
        private readonly string _matchText;
        public string Alt { get;private set; }
        public string Src { get;private set; }
        public HtmlService()
        {
            InitializeComponent();
            _url = textBox2.Text;
            _matchText = textBox1.Text;
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

        public bool FindNodeWithText()
        {
            var doc = new HtmlDocument();
            var pageHtml = GetPageHtml();
            doc.LoadHtml(pageHtml);
            var nodes = doc.DocumentNode.Descendants("img");
            foreach (var node in nodes)
            {
                var alt = node.GetAttributeValue("alt", "");
                var src = node.GetAttributeValue("src", "");

                if (alt.ToLower().Contains(_matchText.ToLower()) || src.ToLower().Contains(_matchText.ToLower()))
                {
                    Alt = alt;
                    Src = src;
                }
            }
            return true;
        }
    }
}
