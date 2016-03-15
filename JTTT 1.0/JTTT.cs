using System;
using System.Windows.Forms;

namespace JTTT_1._0
{
    public partial class JTTT : Form
    {
        public JTTT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = new HtmlService(URL.Text.Contains("http://")? URL.Text: "http://"+URL.Text);

            string path = s.GetPctUrl(KeyWord.Text);
            FileDownloader.DownloadImg(path);
            const string myEmailAddres = "zpompka666@gmail.com";
            const string myPassword = "klop0000";

            string receiverAddres = EmailAdress.Text;
            string fileAtt = "obrazek.jpg";
            string emailBody = "To jest obrazek ze strony " + URL.Text + " zawierający słowo klucz \"" + KeyWord.Text + "\"";
            string subject = "Very important message";

            IEmailService emailService = new SMTPService(gmailConfig.server, gmailConfig.port, myEmailAddres, myPassword);
            SingleMsgWithAttachment msgA = new SingleMsgWithAttachment(myEmailAddres, receiverAddres, fileAtt, subject, emailBody);
            emailService.Send(msgA);
        }

        private void URL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
