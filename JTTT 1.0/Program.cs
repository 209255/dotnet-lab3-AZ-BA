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
            //ActionsProducer producer = new ActionsProducer();
            //ReactionProducer reaction = new ReactionProducer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new JTTT());
        }
    }
}
