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
            string receiverAddres = "ziele3920@hotmail.com";
            string fileAtt = "JTTT 1.0.exe.config";

            var emailService = services.emailService;
            SimpleMsg msg = new SimpleMsg(receiverAddres, "Testing SimpleMsg", "SimpleMsg working!");
            emailService.Send(msg);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            HTMLService ser = new HTMLService("http://demotywatory.pl");
            ser.GetPageHtml();
            ser.PrintPageNodes();


        }
    }
}
