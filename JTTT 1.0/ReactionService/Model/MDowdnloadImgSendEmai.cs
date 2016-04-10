using System;

namespace JTTT_1._0
{
    [Serializable]
    class MDowdnloadImgSendEmai : IModel
    {
       
        public string EmailReceiverAddress { get; set; }
        public string ImgURL { get; set; }
        public string Description { get; set; }

        public override void FillModel(string[] args)
        {
            URL = args[0];
            EmailReceiverAddress = args[1];
        }

        public override void Complemet(string[] args)
        {
            ImgURL = args[0];
            Description = args[1];
        }
    }
}
