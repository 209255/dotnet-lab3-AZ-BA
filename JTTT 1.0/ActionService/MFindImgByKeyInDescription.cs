using System;

namespace JTTT_1._0
{
    [Serializable]
    class MFindImgByKeyInDescription : IModel
    {
        
        public virtual IAction Action { get; set; }
        public string KeyWord { get; set; }

        public override void FillModel(string[] args)
        {
            URL = args[0];
            KeyWord = args[1];
        }

        public override void Complemet(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
