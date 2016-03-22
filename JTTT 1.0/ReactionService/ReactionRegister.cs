using System.Collections.Generic;
using System.Linq;

namespace JTTT_1._0
{
    class ReactionRegister
    {
        readonly Dictionary<string, IReaction> _reg;

        public void RegisterReaction(IReaction reaction)
        {
            _reg.Add(reaction.GetReactionName(), reaction);
        }

        public IReaction GetReaction(string reactionName)
        {
            return _reg[reactionName];
        }

        public List<string> GetReactionNames()
        {
            return _reg.Select(reaction => reaction.Key).ToList();
        }

        public ReactionRegister()
        {
            _reg = new Dictionary<string, IReaction>();
        }

    }
}
