namespace JTTT_1._0
{
    class Task
    {
        public IAction Action { get; private set; }
        public IReaction Reaction { get; private set; }
        public Model ActionModel { get; private set; }
        public Model ReactionModel { get; private set; }
        public string Name { get; private set; }

        public Task(IAction action, IReaction reaction, Model actionModel, Model reactionModel)
        {
            Action = action;
            Reaction = reaction;
            ActionModel = actionModel;
            ReactionModel = reactionModel;
            Name = $"Action: {Action.GetActionName()} \nReaction: {Reaction.GetReactionName()}"; 
        }

        public override string ToString()
        {
            return Name;
        }

        public bool Execute()
        {
            var rModel = ReactionModel as MDowdnloadImgSendEmai;
            rModel.ImgURL = Action.DoAction(ActionModel);
            Reaction.DoReaction(rModel);
            return true;
        }
    }
}
