using System;

namespace JTTT_1._0
{
    [Serializable]
    class MDowdnloadImgSendEmai : IModel
    {
        public string URL { get; set; }
        public string EmailReceiverAddress { get; set; }
        public string ImgURL { get; set; }
    }
}
