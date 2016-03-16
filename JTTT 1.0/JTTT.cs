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
            const string myEmailAddres = "zpompka666@gmail.com";
            const string myPassword = "klop0000";

            //string receiverAddres = EmailAdress.Text;
            string emailBody = "To jest obrazek ze strony " + URL.Text + " zawierający słowo klucz \"" + KeyWord.Text + "\"";
            string subject = "Very important message";

            string fileAtt = Services.Instance.actionRegister.GetAction(comboBox1.Text).DoAction(URL.Text, KeyWord.Text);

            IEmailService emailService = new SMTPService(gmailConfig.server, gmailConfig.port, myEmailAddres, myPassword);
            SingleMsgWithAttachment msgA = new SingleMsgWithAttachment(myEmailAddres, EmailAdress.Text, fileAtt, subject, emailBody);
            emailService.Send(msgA);
        }

        private void URL_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
