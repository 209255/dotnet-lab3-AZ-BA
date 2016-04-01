using System;

namespace JTTT_1._0
{
    [Serializable]
    public class Task
    {
        public int? ActionId { get; set; } 
        public virtual IAction Action { get; set; }
        public int? ReactionId { get; set; }
        public virtual IReaction Reaction { get;  set; }
        public int? ActionModelId { get; set; }
        public virtual Model ActionModel { get;  set; }
        public int? ReactionModelId { get; set; }
        public virtual Model ReactionModel { get; set; }
        public string Name { get;  set; }
        
        public Task(IAction action, IReaction reaction, Model actionModel, Model reactionModel,string name)
        {
            Action = action;
            Reaction = reaction;
            ActionModel = actionModel;
            ReactionModel = reactionModel;
            Name = $"TaskName = {name} Action = {Action.GetActionName()} \nReaction = {Reaction.GetReactionName()}"; 
        }

        public override string ToString()
        {
            return Name;
        }

        public bool Execute()
        {
            var rModel = ReactionModel as MDowdnloadImgSendEmai;
            if (rModel == null) return false;
            rModel.ImgURL = Action.DoAction(ActionModel);
            Reaction.DoReaction(rModel);
            return true;
        }
    }
}
