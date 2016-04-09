using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace JTTT_1._0
{
    [Serializable]
    public class Task
    {
        public int Id { get; set; }
       // public int? ActionId { get; set; }
        //[ForeignKey("ActionId")]
        public virtual IAction Action { get;set; }
     //  public int? ReactionId { get; set; }
       // [ForeignKey("ReactionId")]
        public virtual IReaction Reaction { get;  set; }
      //  public int? ActionModelId { get; set; }
     //  [ForeignKey("ActionModelId")]
        public virtual IModel ActionModel { get;  set; }
      //  public int? ReactionModelId { get; set; }
        // [ForeignKey("ReactionModelId")]
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
            rModel.ImgURL = Action.DoAction(ActionModel);
            if (rModel.ImgURL == null) return false;
            Reaction.DoReaction(rModel);
            return true;
        }
    }
}
