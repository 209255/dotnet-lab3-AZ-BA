using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTTT_1._0
{
    [Serializable]
    class DownloadAndDisplay : IReaction
    {
        public string ReactionName { get; set; } = "Display image";
        public override string GetReactionName()
        {
            return ReactionName;
        }

        public override void DoReaction(IModel model)
        {
            var myModel = model as MDowdnloadImgSendEmai;

        }

        public override IModel GetEmptyModel()
        {
            return new MDowdnloadImgSendEmai();
        }
    }
}
