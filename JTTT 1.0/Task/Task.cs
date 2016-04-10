using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace JTTT_1._0
{
    [Serializable]
    public class Task
    {
        public int Id { get; set; }
        public virtual IAction Action { get;set; }
        public virtual IReaction Reaction { get;  set; }
        public virtual IModel ActionModel { get;  set; }
        public virtual IModel ReactionModel { get; set; }
        public string Name { get;  set; }

        public Task()
        {
        }

        public Task(IAction action, IReaction reaction, IModel actionModel, IModel reactionModel,string name)
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
            string[] data = Action.DoAction(ActionModel);
            if (data == null) return false;
            rModel.Complemet(data);
            Reaction.DoReaction(rModel);
            return true;
        }
    }
}
