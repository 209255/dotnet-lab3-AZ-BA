using System;

namespace JTTT_1._0
{
    [Serializable]
    class MFindImgByKeyInDescription : IModel
    {
        
        public virtual IAction Action { get; set; }
        public string URL { get; set; }
        public string KeyWord { get; set; }

    }
}
