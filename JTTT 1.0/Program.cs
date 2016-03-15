using System;
using System.Windows.Forms;

namespace JTTT_1._0
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Services services = Services.Instance;
            string myEmailAddres = "zpompka666@gmail.com";
            string myPassword = "klop0000";
            string receiverAddres = "ziele3920@hotmail.com";
            string fileAtt = "JTTT 1.0.exe.config";


            IEmailService emailService = new SMTPService(gmailConfig.server, gmailConfig.port, myEmailAddres, myPassword);
            SimpleMsg msg = new SimpleMsg(myEmailAddres, receiverAddres, "Testing SimpleMsg", "SimpleMsg working!");
            //emailService.Send(msg);
            SingleMsgWithAttachment msgA = new SingleMsgWithAttachment(myEmailAddres, receiverAddres, fileAtt, "Message with attachment test", "Message with Attachment Working!");
            //emailService.Send(msgA);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new JTTT());
            


        }
    }
}
