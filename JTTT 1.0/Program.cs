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
         //   Services services = Services.Instance;
           // string receiverAddres = "ziele3920@hotmail.com";
          //  string fileAtt = "JTTT 1.0.exe.config";

           // var EmailService = services.EmailService;
           // SimpleMsg msg = new SimpleMsg(receiverAddres, "Testing SimpleMsg", "SimpleMsg working!");
           // EmailService.Send(msg);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new JTTT());
            


        }
    }
}
