﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Services s = Services.Instance;

             s.Htmlservice.GetPctUrl("http://demotywatory.pl","tym");
             string path = s.Htmlservice.Pcturl;
             FileDownloader.DownloadImg(path);
            const string myEmailAddres = "zpompka666@gmail.com";
            const string myPassword = "klop0000";
            const string receiverAddres = "ziele3920@hotmail.com";
            const string fileAtt = "JTTT 1.0.exe.config";


            //IEmailService emailService = new SMTPService(gmailConfig.server, gmailConfig.port, myEmailAddres, myPassword);
           // SimpleMsg msg = new SimpleMsg(myEmailAddres, receiverAddres, "Testing SimpleMsg", "SimpleMsg working!");
            //emailService.Send(msg);
           // SingleMsgWithAttachment msgA = new SingleMsgWithAttachment(myEmailAddres, receiverAddres, fileAtt, "Message with attachment test", "Message with Attachment Working!");
            //emailService.Send(msgA);
        }
    }
}